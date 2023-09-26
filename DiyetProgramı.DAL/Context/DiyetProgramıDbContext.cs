﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using DiyetProgramı.Entities.Concrete;

namespace DiyetProgramı.DAL.Context
{
    public class DiyetProgramıDbContext : DbContext
    {
        public DbSet<Yemek> Yemekler { get; set; }
        public DbSet<Ogun> Ogunler { get; set; }
        public DbSet<YemekCesit> YemekCesitler { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
        }
    }
}
