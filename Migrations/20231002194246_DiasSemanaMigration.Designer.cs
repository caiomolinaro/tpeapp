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
    [Migration("20231002194246_DiasSemanaMigration")]
    partial class DiasSemanaMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("tpeapp.Models.DiasSemana", b =>
                {
                    b.Property<bool>("Domingo")
                        .HasColumnType("bit");

                    b.Property<bool>("QuartaFeira")
                        .HasColumnType("bit");

                    b.Property<bool>("QuintaFeira")
                        .HasColumnType("bit");

                    b.Property<bool>("Sabado")
                        .HasColumnType("bit");

                    b.Property<bool>("SegundaFeira")
                        .HasColumnType("bit");

                    b.Property<bool>("SextaFeira")
                        .HasColumnType("bit");

                    b.Property<bool>("TercaFeira")
                        .HasColumnType("bit");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.ToTable("DiasSemana");
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

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
