﻿// <auto-generated />
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
    [Migration("20231003204642_privilegesupdate")]
    partial class privilegesupdate
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

                    b.ToTable("Circuits");
                });

            modelBuilder.Entity("tpeapp.Models.CongregationsModel", b =>
                {
                    b.Property<int>("CongregationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CongregationId"));

                    b.Property<string>("CongregationName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CongregationId");

                    b.ToTable("Congregations");
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

                    b.Property<bool>("IsPioneerAndElder")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPioner")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPionerAndMinisterialServante")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPublisher")
                        .HasColumnType("bit");

                    b.HasKey("PrivilegesId");

                    b.ToTable("Privileges");
                });

            modelBuilder.Entity("tpeapp.Models.Schedules", b =>
                {
                    b.Property<int>("HorariosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HorariosId"));

                    b.Property<string>("TimeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HorariosId");

                    b.ToTable("Horarios");
                });

            modelBuilder.Entity("tpeapp.Models.Usuarios", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsuarioId"));

                    b.Property<string>("UsuarioEmail")
                        .IsRequired()
                        .HasMaxLength(22)
                        .HasColumnType("nvarchar(22)");

                    b.Property<string>("UsuarioNome")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("UsuarioTelefone")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<bool>("isHomem")
                        .HasColumnType("bit");

                    b.Property<bool>("isMulher")
                        .HasColumnType("bit");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");
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
#pragma warning restore 612, 618
        }
    }
}
