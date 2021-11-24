﻿// <auto-generated />
using System;
using EFcrud.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFcrud.Migrations
{
    [DbContext(typeof(StripsContext))]
    partial class StripsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFcrud.Model.Auteur", b =>
                {
                    b.Property<int>("AuteurID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naam")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuteurID");

                    b.ToTable("Auteurs");
                });

            modelBuilder.Entity("EFcrud.Model.AuteurStrip", b =>
                {
                    b.Property<int>("StripID")
                        .HasColumnType("int");

                    b.Property<int>("AuteurID")
                        .HasColumnType("int");

                    b.HasKey("StripID", "AuteurID");

                    b.HasIndex("AuteurID");

                    b.ToTable("AuteurStrip");
                });

            modelBuilder.Entity("EFcrud.Model.Reeks", b =>
                {
                    b.Property<int>("ReeksID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naam")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReeksID");

                    b.ToTable("Reeksen");
                });

            modelBuilder.Entity("EFcrud.Model.Strip", b =>
                {
                    b.Property<int>("StripID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Nr")
                        .HasColumnType("int");

                    b.Property<int?>("ReeksID")
                        .HasColumnType("int");

                    b.Property<string>("Titel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UitgeverijID")
                        .HasColumnType("int");

                    b.HasKey("StripID");

                    b.HasIndex("ReeksID");

                    b.HasIndex("UitgeverijID");

                    b.ToTable("Strips");
                });

            modelBuilder.Entity("EFcrud.Model.Uitgeverij", b =>
                {
                    b.Property<int>("UitgeverijID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naam")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UitgeverijID");

                    b.ToTable("Uitgeverijen");
                });

            modelBuilder.Entity("EFcrud.Model.AuteurStrip", b =>
                {
                    b.HasOne("EFcrud.Model.Auteur", "Auteur")
                        .WithMany("StripsLink")
                        .HasForeignKey("AuteurID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFcrud.Model.Strip", "Strip")
                        .WithMany("AuteursLink")
                        .HasForeignKey("StripID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EFcrud.Model.Strip", b =>
                {
                    b.HasOne("EFcrud.Model.Reeks", "Reeks")
                        .WithMany("Strips")
                        .HasForeignKey("ReeksID");

                    b.HasOne("EFcrud.Model.Uitgeverij", "Uitgever")
                        .WithMany()
                        .HasForeignKey("UitgeverijID");
                });
#pragma warning restore 612, 618
        }
    }
}