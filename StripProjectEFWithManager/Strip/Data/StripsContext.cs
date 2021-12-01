using Microsoft.EntityFrameworkCore;
using StripProjectEF.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace StripProjectEF {
   public class StripsContext : DbContext{
        public DbSet<Strip> Strips { get; set; }
        public DbSet<Auteur> Auteurs { get; set; }
        public DbSet<Reeks> Reeksen { get; set; }
        public DbSet<Uitgeverij> Uitgeverijen { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=StripsDB;Integrated Security=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<AuteurStrip>().HasKey(x => new { x.StripID, x.AuteurID });
        }
    }
}
