// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StripProjectEF;

namespace StripProjectEF.Migrations
{
    [DbContext(typeof(StripsContext))]
    [Migration("20211201084154_initial-commit")]
    partial class initialcommit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AuteurStrip", b =>
                {
                    b.Property<int>("AuteursAutuerId")
                        .HasColumnType("int");

                    b.Property<int>("StripsStripId")
                        .HasColumnType("int");

                    b.HasKey("AuteursAutuerId", "StripsStripId");

                    b.HasIndex("StripsStripId");

                    b.ToTable("AuteurStrip");
                });

            modelBuilder.Entity("StripProjectEF.Model.Auteur", b =>
                {
                    b.Property<int>("AutuerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naam")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AutuerId");

                    b.ToTable("Auteurs");
                });

            modelBuilder.Entity("StripProjectEF.Model.Reeks", b =>
                {
                    b.Property<int>("ReeksId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naam")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReeksId");

                    b.ToTable("Reeks");
                });

            modelBuilder.Entity("StripProjectEF.Model.Strip", b =>
                {
                    b.Property<int>("StripId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Nummer")
                        .HasColumnType("int");

                    b.Property<int?>("ReeksId")
                        .HasColumnType("int");

                    b.Property<string>("Titel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UitgeverijId")
                        .HasColumnType("int");

                    b.HasKey("StripId");

                    b.HasIndex("ReeksId");

                    b.HasIndex("UitgeverijId");

                    b.ToTable("Strips");
                });

            modelBuilder.Entity("StripProjectEF.Model.Uitgeverij", b =>
                {
                    b.Property<int>("UitgeverijId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naam")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UitgeverijId");

                    b.ToTable("Uitgeverijen");
                });

            modelBuilder.Entity("AuteurStrip", b =>
                {
                    b.HasOne("StripProjectEF.Model.Auteur", null)
                        .WithMany()
                        .HasForeignKey("AuteursAutuerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StripProjectEF.Model.Strip", null)
                        .WithMany()
                        .HasForeignKey("StripsStripId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StripProjectEF.Model.Strip", b =>
                {
                    b.HasOne("StripProjectEF.Model.Reeks", "Reeks")
                        .WithMany("Strips")
                        .HasForeignKey("ReeksId");

                    b.HasOne("StripProjectEF.Model.Uitgeverij", "Uitgeverij")
                        .WithMany()
                        .HasForeignKey("UitgeverijId");

                    b.Navigation("Reeks");

                    b.Navigation("Uitgeverij");
                });

            modelBuilder.Entity("StripProjectEF.Model.Reeks", b =>
                {
                    b.Navigation("Strips");
                });
#pragma warning restore 612, 618
        }
    }
}
