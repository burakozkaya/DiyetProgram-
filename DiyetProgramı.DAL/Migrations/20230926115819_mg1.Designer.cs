﻿// <auto-generated />
using System;
using DiyetProgramı.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DiyetProgramı.DAL.Migrations
{
    [DbContext(typeof(DiyetProgramıDbContext))]
    [Migration("20230926115819_mg1")]
    partial class mg1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DiyetProgramı.Entities.Concrete.Kullanici", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("KullaniciMail")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("KullaniciSifre")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.HasKey("Id");

                    b.ToTable("Kullanicilar");
                });

            modelBuilder.Entity("DiyetProgramı.Entities.Concrete.Ogun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("KullaniciId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OgunVakti")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("KullaniciId");

                    b.ToTable("Ogunler");
                });

            modelBuilder.Entity("DiyetProgramı.Entities.Concrete.Yemek", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Kalori")
                        .HasPrecision(5, 2)
                        .HasColumnType("decimal(5,2)");

                    b.Property<int>("Kategorileri")
                        .HasColumnType("int");

                    b.Property<string>("ResimYolu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YemekAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("YemekPorsiyon")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Yemekler");
                });

            modelBuilder.Entity("OgunYemek", b =>
                {
                    b.Property<int>("OgunlerId")
                        .HasColumnType("int");

                    b.Property<int>("YemeklerId")
                        .HasColumnType("int");

                    b.HasKey("OgunlerId", "YemeklerId");

                    b.HasIndex("YemeklerId");

                    b.ToTable("OgunYemek");
                });

            modelBuilder.Entity("DiyetProgramı.Entities.Concrete.Ogun", b =>
                {
                    b.HasOne("DiyetProgramı.Entities.Concrete.Kullanici", "Kullanici")
                        .WithMany("Ogunler")
                        .HasForeignKey("KullaniciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kullanici");
                });

            modelBuilder.Entity("OgunYemek", b =>
                {
                    b.HasOne("DiyetProgramı.Entities.Concrete.Ogun", null)
                        .WithMany()
                        .HasForeignKey("OgunlerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DiyetProgramı.Entities.Concrete.Yemek", null)
                        .WithMany()
                        .HasForeignKey("YemeklerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DiyetProgramı.Entities.Concrete.Kullanici", b =>
                {
                    b.Navigation("Ogunler");
                });
#pragma warning restore 612, 618
        }
    }
}
