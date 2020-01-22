﻿// <auto-generated />
using System;
using CmsModulesManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CmsModulesManagement.Migrations
{
    [DbContext(typeof(SiteDbContext))]
    partial class SiteDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("CmsModulesManagement.Models.Entities.SiteCorsPolicy", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("AllowCredential");

                    b.Property<string>("AllowedExposedHeaders");

                    b.Property<string>("AllowedHeaders");

                    b.Property<string>("AllowedMethods");

                    b.Property<string>("AllowedOrigins");

                    b.Property<int>("Availability");

                    b.Property<double>("CreatedTime");

                    b.Property<double?>("LastModifiedTime");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("CorsPolicies");
                });

            modelBuilder.Entity("CmsModulesManagement.Models.Entities.SiteMailClientSetting", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Availability");

                    b.Property<string>("BlindCarbonCopies");

                    b.Property<string>("CarbonCopies");

                    b.Property<double>("CreatedTime");

                    b.Property<string>("DisplayName");

                    b.Property<double?>("LastModifiedTime");

                    b.Property<string>("MailHost");

                    b.Property<Guid>("TenantId");

                    b.Property<int>("Timeout");

                    b.Property<string>("UniqueName")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UniqueName", "TenantId")
                        .IsUnique();

                    b.ToTable("SiteMailClientSettings");
                });

            modelBuilder.Entity("CmsModulesManagement.Models.Entities.SiteSetting", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ActiveMailClient");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("ClientSettings");
                });
#pragma warning restore 612, 618
        }
    }
}
