﻿using System;
using System.Net;
using System.Net.Mail;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Tekiz.Core.Permissions;
using Tekiz.Core.Roles;
using Tekiz.Core.Users;
using Tekiz.EntityFramework;
using Tekiz.Web.Core.ActionFilters;
using Tekiz.Web.Core.Authentication;

namespace Tekiz.Web.Core.Extensions
{
    public static class ServiceCollection
    {
        private static SymmetricSecurityKey _signingKey;
        private static JwtTokenConfiguration _jwtTokenConfiguration;

        public static void ConfigureCors(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(configuration["App:CorsOriginPolicyName"],
                    builder =>
                        builder.WithOrigins(configuration["App:CorsOrigins"]
                                .Split(",", StringSplitOptions.RemoveEmptyEntries))
                            .AllowAnyHeader()
                            .AllowAnyMethod());
            });
        }

        public static void ConfigureAuthentication(this IServiceCollection services)
        {
            services.AddIdentity<User, Role>()
                .AddEntityFrameworkStores<TekizDbContext>()
                .AddDefaultTokenProviders();

            services.AddAuthorization(options =>
            {
                foreach (var permission in DefaultPermissions.All())
                {
                    options.AddPolicy(permission.Name,
                        policy => policy.Requirements.Add(new PermissionRequirement(permission)));
                }
            });
        }

        public static void ConfigureDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING");
            if (!String.IsNullOrEmpty(connectionString))
            {
                services.AddDbContext<TekizDbContext>(options =>
                   options.UseNpgsql(
                       connectionString
                   )
                   .UseLazyLoadingProxies()
                );
            }
            else
            {
                services.AddDbContext<TekizDbContext>(options =>
                   options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"))
                   .UseLazyLoadingProxies()
                );
            }
        }

        public static void ConfigureDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<IAuthorizationHandler, PermissionHandler>();
            services.AddScoped<UnitOfWorkActionFilter>();
        }

        public static void ConfigureJwtTokenAuth(this IServiceCollection services, IConfiguration configuration)
        {
            _signingKey =
                new SymmetricSecurityKey(
                    Encoding.ASCII.GetBytes(configuration["Authentication:JwtBearer:SecurityKey"]));

            _jwtTokenConfiguration = new JwtTokenConfiguration
            {
                Issuer = configuration["Authentication:JwtBearer:Issuer"],
                Audience = configuration["Authentication:JwtBearer:Audience"],
                SigningCredentials = new SigningCredentials(_signingKey, SecurityAlgorithms.HmacSha256),
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(60),
            };

            services.Configure<JwtTokenConfiguration>(config =>
            {
                config.Audience = _jwtTokenConfiguration.Audience;
                config.EndDate = _jwtTokenConfiguration.EndDate;
                config.Issuer = _jwtTokenConfiguration.Issuer;
                config.StartDate = _jwtTokenConfiguration.StartDate;
                config.SigningCredentials = _jwtTokenConfiguration.SigningCredentials;
            });

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(jwtBearerOptions =>
            {
                jwtBearerOptions.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateActor = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = _jwtTokenConfiguration.Issuer,
                    ValidAudience = _jwtTokenConfiguration.Audience,
                    IssuerSigningKey = _signingKey
                };
            });
        }

        public static void ConfigureSmtp(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped(serviceProvider => new SmtpClient
            {
                Host = configuration["Email:Smtp:Host"],
                Port = int.Parse(configuration["Email:Smtp:Port"]),
                Credentials = new NetworkCredential(configuration["Email:Smtp:Username"], configuration["Email:Smtp:Password"]),
                EnableSsl = bool.Parse(configuration["Email:Smtp:EnableSsl"])
            });
        }
    }
}
