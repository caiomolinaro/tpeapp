﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using tpeapp.Context;

#nullable disable

namespace tpeapp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231004225700_migracaocircuit1")]
    partial class migracaocircuit1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("tpeapp.Models.CircuitsModel", b =>
                {
                    b.Property<int>("CircuitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CircuitId"));

                    b.Property<string>("CircuitName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CircuitId");

                    b.ToTable("CircuitsName");
                });

            modelBuilder.Entity("tpeapp.Models.CongregationsModel", b =>
                {
                    b.Property<int>("CongregationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CongregationId"));

                    b.Property<int>("CircuitId")
                        .HasColumnType("int");

                    b.Property<int?>("CircuitsCircuitId")
                        .HasColumnType("int");

                    b.Property<string>("CongregationName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CongregationId");

                    b.HasIndex("CircuitsCircuitId");

                    b.ToTable("CongregationsName");
                });

            modelBuilder.Entity("tpeapp.Models.PointsModel", b =>
                {
                    b.Property<int>("PointId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PointId"));

                    b.Property<string>("PointName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PointId");

                    b.ToTable("Points");
                });

            modelBuilder.Entity("tpeapp.Models.PrivilegesModel", b =>
                {
                    b.Property<int>("PrivilegesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PrivilegesId"));

                    b.Property<bool>("IsElder")
                        .HasColumnType("bit");

                    b.Property<bool>("IsMinisterialServant")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPioneer")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPioneerAndElder")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPioneerAndMinisterialServant")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPublisher")
                        .HasColumnType("bit");

                    b.HasKey("PrivilegesId");

                    b.ToTable("Privileges");
                });

            modelBuilder.Entity("tpeapp.Models.SchedulesModel", b =>
                {
                    b.Property<int>("SchedulesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SchedulesId"));

                    b.Property<string>("SchedulesName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SchedulesId");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("tpeapp.Models.UsersModel", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<bool>("IsMan")
                        .HasColumnType("bit");

                    b.Property<bool>("IsWoman")
                        .HasColumnType("bit");

                    b.Property<DateTime>("UserBirthDate")
                        .HasColumnType("Date");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasMaxLength(22)
                        .HasColumnType("nvarchar(22)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("UserPhone")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("tpeapp.Models.WeekDaysModel", b =>
                {
                    b.Property<int>("WeekDayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WeekDayId"));

                    b.Property<bool>("Friday")
                        .HasColumnType("bit");

                    b.Property<bool>("Monday")
                        .HasColumnType("bit");

                    b.Property<bool>("Saturday")
                        .HasColumnType("bit");

                    b.Property<bool>("Sunday")
                        .HasColumnType("bit");

                    b.Property<bool>("Thursday")
                        .HasColumnType("bit");

                    b.Property<bool>("Tuesday")
                        .HasColumnType("bit");

                    b.Property<bool>("Wednesday")
                        .HasColumnType("bit");

                    b.HasKey("WeekDayId");

                    b.ToTable("WeekDays");
                });

            modelBuilder.Entity("tpeapp.Models.CongregationsModel", b =>
                {
                    b.HasOne("tpeapp.Models.CircuitsModel", "Circuits")
                        .WithMany("Congregations")
                        .HasForeignKey("CircuitsCircuitId");

                    b.Navigation("Circuits");
                });

            modelBuilder.Entity("tpeapp.Models.CircuitsModel", b =>
                {
                    b.Navigation("Congregations");
                });
#pragma warning restore 612, 618
        }
    }
}
