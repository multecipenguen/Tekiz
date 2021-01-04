using System.Reflection;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Tekiz.Utilities.Extensions.Collections;

namespace Tekiz.Application
{
    public static class ApplicationServiceCollectionExtensions
    {
        public static IServiceCollection ConfigureTekizApplication(this IServiceCollection services)
        {
            // https://github.com/AutoMapper/AutoMapper.Extensions.Microsoft.DependencyInjection/issues/28#issuecomment-339772823
            services.AddAutoMapper(typeof(ApplicationServiceCollectionExtensions));

            services.RegisterAssemblyPublicNonGenericClasses(Assembly.GetExecutingAssembly())
                .Where(c => c.Name.EndsWith("AppService"))
                .AsPublicImplementedInterfaces();

            return services;
        }
    }
}