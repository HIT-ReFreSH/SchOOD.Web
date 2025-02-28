﻿// <auto-generated />

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace SchOOD.DataBase.Migrations
{
    [DbContext(typeof(SchOODContext))]
    internal class SchOODContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("SchOOD.DataBase.Models.DbCourse", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("char(36)");

                b.Property<long?>("DbUserId")
                    .HasColumnType("bigint");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("longtext CHARACTER SET utf8mb4");

                b.HasKey("Id");

                b.HasIndex("DbUserId");

                b.ToTable("Courses");
            });

            modelBuilder.Entity("SchOOD.DataBase.Models.DbEvent", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("char(36)");

                b.Property<Guid?>("DbCourseId")
                    .HasColumnType("char(36)");

                b.Property<TimeSpan>("Duration")
                    .HasColumnType("time(6)");

                b.Property<string>("Location")
                    .HasColumnType("longtext CHARACTER SET utf8mb4");

                b.Property<DateTime>("StartTime")
                    .HasColumnType("datetime(6)");

                b.Property<string>("Teacher")
                    .HasColumnType("longtext CHARACTER SET utf8mb4");

                b.Property<int>("Type")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.HasIndex("DbCourseId");

                b.ToTable("Events");
            });

            modelBuilder.Entity("SchOOD.DataBase.Models.DbUser", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("bigint");

                b.Property<string>("CalendarPath")
                    .IsRequired()
                    .HasColumnType("longtext CHARACTER SET utf8mb4");

                b.HasKey("Id");

                b.ToTable("Users");
            });

            modelBuilder.Entity("SchOOD.DataBase.Models.DbUserRule", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("char(36)");

                b.Property<string>("Argument")
                    .HasColumnType("longtext CHARACTER SET utf8mb4");

                b.Property<long?>("DbUserId")
                    .HasColumnType("bigint");

                b.Property<short>("Effect")
                    .HasColumnType("smallint");

                b.Property<Guid>("Target")
                    .HasColumnType("char(36)");

                b.HasKey("Id");

                b.HasIndex("DbUserId");

                b.ToTable("Rules");
            });

            modelBuilder.Entity("SchOOD.DataBase.Models.DbCourse", b =>
            {
                b.HasOne("SchOOD.DataBase.Models.DbUser", null)
                    .WithMany("Courses")
                    .HasForeignKey("DbUserId");
            });

            modelBuilder.Entity("SchOOD.DataBase.Models.DbEvent", b =>
            {
                b.HasOne("SchOOD.DataBase.Models.DbCourse", null)
                    .WithMany("Events")
                    .HasForeignKey("DbCourseId");
            });

            modelBuilder.Entity("SchOOD.DataBase.Models.DbUserRule", b =>
            {
                b.HasOne("SchOOD.DataBase.Models.DbUser", null)
                    .WithMany("Rules")
                    .HasForeignKey("DbUserId");
            });

            modelBuilder.Entity("SchOOD.DataBase.Models.DbCourse", b => { b.Navigation("Events"); });

            modelBuilder.Entity("SchOOD.DataBase.Models.DbUser", b =>
            {
                b.Navigation("Courses");

                b.Navigation("Rules");
            });
#pragma warning restore 612, 618
        }
    }
}