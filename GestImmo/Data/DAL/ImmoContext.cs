using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using GestImmo.Models;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GestImmo.Data.DAL
{
    public class ImmoContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Host=localhost;Database=GestImmo;Username=postgres;Password=SmvTmjsunp7");

        public DbSet<Contrat> Contrat { get; set; }

        public DbSet<Bien> Bien { get; set; }

        public DbSet<Intervention> Intervention { get; set; }

        public DbSet<Locataire> Locataire { get; set; }

        public DbSet<Prestataire> Prestataire { get; set; }

        public DbSet<Pret> Pret { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Logement>().ToTable("Logement");
            modelBuilder.Entity<Appartement>().ToTable("Appartement");
            modelBuilder.Entity<Maison>().ToTable("Maison");
            modelBuilder.Entity<Box>().ToTable("Box");

        }

        private static ImmoContext? instance;

        public static ImmoContext getInstance()
        {
            if (instance == null)
            {
                instance = new ImmoContext();
            }

            return instance;
        }

        

    }

}


