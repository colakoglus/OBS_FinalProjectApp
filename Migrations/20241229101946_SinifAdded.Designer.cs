﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OBS_FinalProjectApp;

#nullable disable

namespace OBS_FinalProjectApp.Migrations
{
    [DbContext(typeof(FinalProjectContext))]
    [Migration("20241229101946_SinifAdded")]
    partial class SinifAdded
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OBS_FinalProjectApp.Ders", b =>
                {
                    b.Property<int>("DersId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DersId"));

                    b.Property<string>("DersAd")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar");

                    b.Property<string>("DersKod")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("varchar");

                    b.HasKey("DersId");

                    b.ToTable("Dersler");
                });

            modelBuilder.Entity("OBS_FinalProjectApp.Ogrenci", b =>
                {
                    b.Property<int>("OgrenciId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OgrenciId"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar");

                    b.Property<string>("Numara")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("varchar");

                    b.Property<int>("SinifId")
                        .HasColumnType("int");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar");

                    b.HasKey("OgrenciId");

                    b.HasIndex("SinifId");

                    b.ToTable("Ogrenciler");
                });

            modelBuilder.Entity("OBS_FinalProjectApp.OgrenciDers", b =>
                {
                    b.Property<int>("OgrenciId")
                        .HasColumnType("int");

                    b.Property<int>("DersId")
                        .HasColumnType("int");

                    b.HasKey("OgrenciId", "DersId");

                    b.HasIndex("DersId");

                    b.ToTable("OgrenciDersler");
                });

            modelBuilder.Entity("OBS_FinalProjectApp.Sinif", b =>
                {
                    b.Property<int>("SinifId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SinifId"));

                    b.Property<string>("Kontenjan")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("varchar");

                    b.Property<string>("SinifAd")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("varchar");

                    b.HasKey("SinifId");

                    b.ToTable("Siniflar");
                });

            modelBuilder.Entity("OBS_FinalProjectApp.Ogrenci", b =>
                {
                    b.HasOne("OBS_FinalProjectApp.Sinif", "Sinif")
                        .WithMany("Ogrenciler")
                        .HasForeignKey("SinifId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sinif");
                });

            modelBuilder.Entity("OBS_FinalProjectApp.OgrenciDers", b =>
                {
                    b.HasOne("OBS_FinalProjectApp.Ders", "Ders")
                        .WithMany("OgrenciDersler")
                        .HasForeignKey("DersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OBS_FinalProjectApp.Ogrenci", "Ogrenci")
                        .WithMany("OgrenciDersler")
                        .HasForeignKey("OgrenciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ders");

                    b.Navigation("Ogrenci");
                });

            modelBuilder.Entity("OBS_FinalProjectApp.Ders", b =>
                {
                    b.Navigation("OgrenciDersler");
                });

            modelBuilder.Entity("OBS_FinalProjectApp.Ogrenci", b =>
                {
                    b.Navigation("OgrenciDersler");
                });

            modelBuilder.Entity("OBS_FinalProjectApp.Sinif", b =>
                {
                    b.Navigation("Ogrenciler");
                });
#pragma warning restore 612, 618
        }
    }
}