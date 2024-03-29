﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Tekiz.EntityFramework;

namespace Tekiz.EntityFramework.Migrations
{
    [DbContext(typeof(TekizDbContext))]
    partial class TekizDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Tekiz.Core.Permissions.Permission", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("CreatorId")
                        .HasColumnType("uuid");

                    b.Property<string>("DisplayName")
                        .HasColumnType("text");

                    b.Property<DateTime>("ModificationDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("ModifierId")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Permission");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2a1ccb43-fa4f-48ce-b601-d3ab4d611b32"),
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatorId = new Guid("00000000-0000-0000-0000-000000000000"),
                            DisplayName = "Administration access",
                            ModificationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ModifierId = new Guid("00000000-0000-0000-0000-000000000000"),
                            Name = "Permissions_Administration"
                        },
                        new
                        {
                            Id = new Guid("28126ffd-51c2-4201-939c-b64e3df43b9d"),
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatorId = new Guid("00000000-0000-0000-0000-000000000000"),
                            DisplayName = "Member access",
                            ModificationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ModifierId = new Guid("00000000-0000-0000-0000-000000000000"),
                            Name = "Permissions_Member_Access"
                        },
                        new
                        {
                            Id = new Guid("86d804bd-d022-49a5-821a-d2240478aac4"),
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatorId = new Guid("00000000-0000-0000-0000-000000000000"),
                            DisplayName = "User read",
                            ModificationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ModifierId = new Guid("00000000-0000-0000-0000-000000000000"),
                            Name = "Permissions_User_Read"
                        },
                        new
                        {
                            Id = new Guid("8f3de3ec-3851-4ba9-887a-2119f18ae744"),
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatorId = new Guid("00000000-0000-0000-0000-000000000000"),
                            DisplayName = "User create",
                            ModificationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ModifierId = new Guid("00000000-0000-0000-0000-000000000000"),
                            Name = "Permissions_User_Create"
                        },
                        new
                        {
                            Id = new Guid("068a0171-a141-4eb2-854c-88e43ef9ab7f"),
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatorId = new Guid("00000000-0000-0000-0000-000000000000"),
                            DisplayName = "User update",
                            ModificationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ModifierId = new Guid("00000000-0000-0000-0000-000000000000"),
                            Name = "Permissions_User_Update"
                        },
                        new
                        {
                            Id = new Guid("70b5c5c3-2267-4f7c-b0f9-7ecc952e04a6"),
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatorId = new Guid("00000000-0000-0000-0000-000000000000"),
                            DisplayName = "User delete",
                            ModificationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ModifierId = new Guid("00000000-0000-0000-0000-000000000000"),
                            Name = "Permissions_User_Delete"
                        },
                        new
                        {
                            Id = new Guid("80562f50-8a7d-4bcd-8971-6d856bbcbb7f"),
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatorId = new Guid("00000000-0000-0000-0000-000000000000"),
                            DisplayName = "Role read",
                            ModificationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ModifierId = new Guid("00000000-0000-0000-0000-000000000000"),
                            Name = "Permissions_Role_Read"
                        },
                        new
                        {
                            Id = new Guid("d4d7c0e3-efcf-4dd2-86e7-17d69fda8c75"),
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatorId = new Guid("00000000-0000-0000-0000-000000000000"),
                            DisplayName = "Role create",
                            ModificationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ModifierId = new Guid("00000000-0000-0000-0000-000000000000"),
                            Name = "Permissions_Role_Create"
                        },
                        new
                        {
                            Id = new Guid("ea003a99-4755-4c19-b126-c5cffbc65088"),
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatorId = new Guid("00000000-0000-0000-0000-000000000000"),
                            DisplayName = "Role update",
                            ModificationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ModifierId = new Guid("00000000-0000-0000-0000-000000000000"),
                            Name = "Permissions_Role_Update"
                        },
                        new
                        {
                            Id = new Guid("8f76de0b-114a-4df8-a93d-cec927d06a3c"),
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatorId = new Guid("00000000-0000-0000-0000-000000000000"),
                            DisplayName = "Role delete",
                            ModificationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ModifierId = new Guid("00000000-0000-0000-0000-000000000000"),
                            Name = "Permissions_Role_Delete"
                        });
                });

            modelBuilder.Entity("Tekiz.Core.Roles.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<bool>("IsSystemDefault")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("Role");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f22bce18-06ec-474a-b9af-a9de2a7b8263"),
                            ConcurrencyStamp = "0dae28c9-26f5-407a-b616-f6968d933159",
                            IsSystemDefault = true,
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = new Guid("11d14a89-3a93-4d39-a94f-82b823f0d4ce"),
                            ConcurrencyStamp = "1f814bc5-d806-44bb-84cf-197f04a8d825",
                            IsSystemDefault = true,
                            Name = "Member",
                            NormalizedName = "MEMBER"
                        });
                });

            modelBuilder.Entity("Tekiz.Core.Roles.RoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaim");
                });

            modelBuilder.Entity("Tekiz.Core.Roles.RolePermission", b =>
                {
                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("PermissionId")
                        .HasColumnType("uuid");

                    b.HasKey("RoleId", "PermissionId");

                    b.HasIndex("PermissionId");

                    b.ToTable("RolePermission");

                    b.HasData(
                        new
                        {
                            RoleId = new Guid("f22bce18-06ec-474a-b9af-a9de2a7b8263"),
                            PermissionId = new Guid("2a1ccb43-fa4f-48ce-b601-d3ab4d611b32")
                        },
                        new
                        {
                            RoleId = new Guid("f22bce18-06ec-474a-b9af-a9de2a7b8263"),
                            PermissionId = new Guid("28126ffd-51c2-4201-939c-b64e3df43b9d")
                        },
                        new
                        {
                            RoleId = new Guid("f22bce18-06ec-474a-b9af-a9de2a7b8263"),
                            PermissionId = new Guid("86d804bd-d022-49a5-821a-d2240478aac4")
                        },
                        new
                        {
                            RoleId = new Guid("f22bce18-06ec-474a-b9af-a9de2a7b8263"),
                            PermissionId = new Guid("8f3de3ec-3851-4ba9-887a-2119f18ae744")
                        },
                        new
                        {
                            RoleId = new Guid("f22bce18-06ec-474a-b9af-a9de2a7b8263"),
                            PermissionId = new Guid("068a0171-a141-4eb2-854c-88e43ef9ab7f")
                        },
                        new
                        {
                            RoleId = new Guid("f22bce18-06ec-474a-b9af-a9de2a7b8263"),
                            PermissionId = new Guid("70b5c5c3-2267-4f7c-b0f9-7ecc952e04a6")
                        },
                        new
                        {
                            RoleId = new Guid("f22bce18-06ec-474a-b9af-a9de2a7b8263"),
                            PermissionId = new Guid("80562f50-8a7d-4bcd-8971-6d856bbcbb7f")
                        },
                        new
                        {
                            RoleId = new Guid("f22bce18-06ec-474a-b9af-a9de2a7b8263"),
                            PermissionId = new Guid("d4d7c0e3-efcf-4dd2-86e7-17d69fda8c75")
                        },
                        new
                        {
                            RoleId = new Guid("f22bce18-06ec-474a-b9af-a9de2a7b8263"),
                            PermissionId = new Guid("ea003a99-4755-4c19-b126-c5cffbc65088")
                        },
                        new
                        {
                            RoleId = new Guid("f22bce18-06ec-474a-b9af-a9de2a7b8263"),
                            PermissionId = new Guid("8f76de0b-114a-4df8-a93d-cec927d06a3c")
                        },
                        new
                        {
                            RoleId = new Guid("11d14a89-3a93-4d39-a94f-82b823f0d4ce"),
                            PermissionId = new Guid("28126ffd-51c2-4201-939c-b64e3df43b9d")
                        });
                });

            modelBuilder.Entity("Tekiz.Core.Users.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c41a7761-6645-4e2c-b99d-f9e767b9ac77"),
                            AccessFailedCount = 5,
                            ConcurrencyStamp = "b0f4fc2d-46b0-4cc9-83b5-2d89568292b6",
                            Email = "admin@mail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@MAIL.COM",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AM4OLBpptxBYmM79lGOX9egzZk3vIQU3d/gFCJzaBjAPXzYIK3tQ2N7X4fcrHtElTw==",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        },
                        new
                        {
                            Id = new Guid("065e903e-6f7b-42b8-b807-0c4197f9d1bc"),
                            AccessFailedCount = 5,
                            ConcurrencyStamp = "729ae890-ef8e-446d-a030-6082bec0d51f",
                            Email = "memberuser@mail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "MEMBERUSER@MAIL.COM",
                            NormalizedUserName = "MEMBERUSER",
                            PasswordHash = "AM4OLBpptxBYmM79lGOX9egzZk3vIQU3d/gFCJzaBjAPXzYIK3tQ2N7X4fcrHtElTw==",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "memberuser"
                        },
                        new
                        {
                            Id = new Guid("4b6d9e45-626d-489a-a8cf-d32d36583af4"),
                            AccessFailedCount = 5,
                            ConcurrencyStamp = "2f4dc390-e103-4ddd-9918-4ac0c282b10f",
                            Email = "testadmin@mail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "TESTADMIN@MAIL.COM",
                            NormalizedUserName = "TESTADMIN",
                            PasswordHash = "AM4OLBpptxBYmM79lGOX9egzZk3vIQU3d/gFCJzaBjAPXzYIK3tQ2N7X4fcrHtElTw==",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "testadmin"
                        });
                });

            modelBuilder.Entity("Tekiz.Core.Users.UserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaim");
                });

            modelBuilder.Entity("Tekiz.Core.Users.UserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogin");
                });

            modelBuilder.Entity("Tekiz.Core.Users.UserRole", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRole");

                    b.HasData(
                        new
                        {
                            UserId = new Guid("c41a7761-6645-4e2c-b99d-f9e767b9ac77"),
                            RoleId = new Guid("f22bce18-06ec-474a-b9af-a9de2a7b8263")
                        },
                        new
                        {
                            UserId = new Guid("4b6d9e45-626d-489a-a8cf-d32d36583af4"),
                            RoleId = new Guid("f22bce18-06ec-474a-b9af-a9de2a7b8263")
                        },
                        new
                        {
                            UserId = new Guid("065e903e-6f7b-42b8-b807-0c4197f9d1bc"),
                            RoleId = new Guid("11d14a89-3a93-4d39-a94f-82b823f0d4ce")
                        });
                });

            modelBuilder.Entity("Tekiz.Core.Users.UserToken", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserToken");
                });

            modelBuilder.Entity("Tekiz.Core.Roles.RoleClaim", b =>
                {
                    b.HasOne("Tekiz.Core.Roles.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Tekiz.Core.Roles.RolePermission", b =>
                {
                    b.HasOne("Tekiz.Core.Permissions.Permission", "Permission")
                        .WithMany("RolePermissions")
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Tekiz.Core.Roles.Role", "Role")
                        .WithMany("RolePermissions")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Permission");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Tekiz.Core.Users.UserClaim", b =>
                {
                    b.HasOne("Tekiz.Core.Users.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Tekiz.Core.Users.UserLogin", b =>
                {
                    b.HasOne("Tekiz.Core.Users.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Tekiz.Core.Users.UserRole", b =>
                {
                    b.HasOne("Tekiz.Core.Roles.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Tekiz.Core.Users.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Tekiz.Core.Users.UserToken", b =>
                {
                    b.HasOne("Tekiz.Core.Users.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Tekiz.Core.Permissions.Permission", b =>
                {
                    b.Navigation("RolePermissions");
                });

            modelBuilder.Entity("Tekiz.Core.Roles.Role", b =>
                {
                    b.Navigation("RolePermissions");

                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("Tekiz.Core.Users.User", b =>
                {
                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
