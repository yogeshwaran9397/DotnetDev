﻿// <auto-generated />
using EFCore_DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCore_DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFCore_Models.Model.Execution", b =>
                {
                    b.Property<int>("ExecutionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExecutionId"));

                    b.Property<string>("ExecutionIndex")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RelativeFolderPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ExecutionId");

                    b.ToTable("ExecutionInfo");

                    b.HasData(
                        new
                        {
                            ExecutionId = 1,
                            ExecutionIndex = "Run1",
                            RelativeFolderPath = "samplepath"
                        });
                });

            modelBuilder.Entity("EFCore_Models.Model.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProjectId"));

                    b.Property<string>("RelativeFolderPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProjectId");

                    b.ToTable("ProjectInfo");
                });

            modelBuilder.Entity("EFCore_Models.Model.TestCase", b =>
                {
                    b.Property<int>("TestCaseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TestCaseId"));

                    b.Property<string>("TestCaseNameEnumFormat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TestCaseNameStringFormat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TestResult")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TestCaseId");

                    b.ToTable("TestInfo");
                });

            modelBuilder.Entity("EFCore_Models.Model.VersionandMeta", b =>
                {
                    b.Property<int>("VersionandMetaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VersionandMetaId"));

                    b.Property<string>("BoardInfo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FWVersion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SWVersion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VersionandMetaId");

                    b.ToTable("VersionInfo");
                });
#pragma warning restore 612, 618
        }
    }
}
