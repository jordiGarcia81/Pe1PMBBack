using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBetOficial.Models.objects
{
    public class PlaceMyBetContext : DbContext
    {
        public DbSet<Apuesta> Apuestas { get; set; } // tablas
        public DbSet<Cuenta> Cuentas { get; set; }
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Mercado> Mercados { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        public PlaceMyBetContext() { }

        public PlaceMyBetContext(DbContextOptions options) : base(options)
        { 

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("Server=localhost;Database=PlaceMyBet3;Uid=root;Pwd=''; SslMode = none");
            }
                
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            DateTime fecha = new DateTime();
            modelBuilder.Entity<Evento>().HasData(new Evento(1, "valencia", "madrid", fecha.Date));
            modelBuilder.Entity<Mercado>().HasData(new Mercado(1, "1.5", 3.8, 1.45, 950, 300, 1));
            modelBuilder.Entity<Usuario>().HasData(new Usuario("jordigarcia@gmail.com", "Jordi", "Garcia Ibor", 39));
            modelBuilder.Entity<Apuesta>().HasData(new Apuesta(1, "under", "1.5", 50, fecha.Date, 1, "jordigarcia@gmail.com"));
            modelBuilder.Entity<Cuenta>().HasData(new Cuenta(1234567876543212, "bankia", 100, "jordigarcia@gmail.com"));
        }
    }
}