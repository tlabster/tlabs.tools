﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tlabs.Data.Store;

#nullable disable

namespace Proto.Module.Migrations
{
    [DbContext(typeof(DStoreContext<AggregatingDStoreCtxConfigurator>))]
    [Migration("20240307140606_TlabsBase")]
    partial class TlabsBase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("Tlabs.Data.Entity.ApiKey", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Editor")
                        .HasColumnType("TEXT");

                    b.Property<string>("Hash")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("TEXT");

                    b.Property<string>("TokenName")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ValidFrom")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("ValidUntil")
                        .HasColumnType("TEXT");

                    b.Property<string>("ValidityState")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Hash")
                        .IsUnique();

                    b.HasIndex("TokenName")
                        .IsUnique();

                    b.ToTable("ApiKey", "Identity");
                });

            modelBuilder.Entity("Tlabs.Data.Entity.ApiKey+RoleRef", b =>
                {
                    b.Property<int?>("ApiKeyId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("RoleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ApiKeyId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("ApiKeyRoleRef", "Identity");
                });

            modelBuilder.Entity("Tlabs.Data.Entity.AuditRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ActionName")
                        .HasColumnType("TEXT");

                    b.Property<string>("BodyData")
                        .HasColumnType("TEXT");

                    b.Property<string>("Editor")
                        .HasColumnType("TEXT");

                    b.Property<string>("Error")
                        .HasColumnType("TEXT");

                    b.Property<string>("IPAddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("Method")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("TEXT");

                    b.Property<string>("StatusCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("URL")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("AuditRecord", "Identity");
                });

            modelBuilder.Entity("Tlabs.Data.Entity.Locale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DateFormat")
                        .HasColumnType("TEXT");

                    b.Property<string>("DateTimeFormat")
                        .HasColumnType("TEXT");

                    b.Property<string>("DecimalSep")
                        .HasColumnType("TEXT");

                    b.Property<string>("FixedFormat")
                        .HasColumnType("TEXT");

                    b.Property<string>("IntegerFormat")
                        .HasColumnType("TEXT");

                    b.Property<string>("Lang")
                        .HasColumnType("TEXT");

                    b.Property<string>("ListSep")
                        .HasColumnType("TEXT");

                    b.Property<string>("MonetaryFormat")
                        .HasColumnType("TEXT");

                    b.Property<string>("ThousandSep")
                        .HasColumnType("TEXT");

                    b.Property<string>("TimeFormat")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Lang")
                        .IsUnique();

                    b.ToTable("Locale", "Identity");
                });

            modelBuilder.Entity("Tlabs.Data.Entity.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AllowAccessPattern")
                        .HasColumnType("TEXT");

                    b.Property<string>("DenyAccessPattern")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Editor")
                        .HasColumnType("TEXT");

                    b.Property<string>("EnforcedFilters")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedRoleName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Role", "Identity");
                });

            modelBuilder.Entity("Tlabs.Data.Entity.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Editor")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Firstname")
                        .HasColumnType("TEXT");

                    b.Property<string>("Lastname")
                        .HasColumnType("TEXT");

                    b.Property<int?>("LocaleId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("LocaleId");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("User", "Identity");
                });

            modelBuilder.Entity("Tlabs.Data.Entity.User+RoleRef", b =>
                {
                    b.Property<int?>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("RoleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoleRef", "Identity");
                });

            modelBuilder.Entity("Tlabs.Data.Entity.ApiKey+RoleRef", b =>
                {
                    b.HasOne("Tlabs.Data.Entity.ApiKey", "ApiKey")
                        .WithMany("Roles")
                        .HasForeignKey("ApiKeyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Tlabs.Data.Entity.Role", "Role")
                        .WithMany("ApiKeys")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApiKey");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Tlabs.Data.Entity.User", b =>
                {
                    b.HasOne("Tlabs.Data.Entity.Locale", "Locale")
                        .WithMany()
                        .HasForeignKey("LocaleId");

                    b.Navigation("Locale");
                });

            modelBuilder.Entity("Tlabs.Data.Entity.User+RoleRef", b =>
                {
                    b.HasOne("Tlabs.Data.Entity.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Tlabs.Data.Entity.User", "User")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Tlabs.Data.Entity.ApiKey", b =>
                {
                    b.Navigation("Roles");
                });

            modelBuilder.Entity("Tlabs.Data.Entity.Role", b =>
                {
                    b.Navigation("ApiKeys");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Tlabs.Data.Entity.User", b =>
                {
                    b.Navigation("Roles");
                });
#pragma warning restore 612, 618
        }
    }
}
