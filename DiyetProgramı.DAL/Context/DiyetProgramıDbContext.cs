﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using DiyetProgramı.Entities.Concrete;
using DiyetProgramı.Entities.Enum;

namespace DiyetProgramı.DAL.Context
{
    internal class DiyetProgramıDbContext : DbContext
    {
        public DbSet<Yemek> Yemekler { get; set; }
        public DbSet<Ogun> Ogunler { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Kullanici>()
                .Property(x => x.KullaniciSifre)
                .HasMaxLength(16);
            modelBuilder
                .Entity<Kullanici>()
                .Property(x=>x.KullaniciMail)
                .HasMaxLength(50);
            modelBuilder
                .Entity<Yemek>()
                .Property(x => x.Kalori)
                .HasPrecision(8, 2);

        }
    }
}
