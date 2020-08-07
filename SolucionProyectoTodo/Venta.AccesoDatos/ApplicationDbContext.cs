using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using Venta.Modelo;
using Venta.Modelo.Entidades;

namespace Venta.AccesoDatos
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appconfig.json")
                .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Electrodomésticos
            modelBuilder.Entity<ProductoElectrodomestico>()
           .ToTable("Electrodomesticos")
           .HasKey(e => new { e.ProductoElectrodomesticoId });
            //Aparatos tecnológicos
            modelBuilder.Entity<ProductoTecnologico>()
            .ToTable("AparatosTecnologicos")
            .HasKey(t => new { t.ProductoTecnologicoId });
            //Bodega de electrodomésticos
            modelBuilder.Entity<BodegaProductoElectrodomestico>()
            .ToTable("BodegaDeElectrodomesticos")
            .HasKey(be => new { be.BodegaProductoElectrodomesticoId });
            //Bodega de aparatos tecnológicos
            modelBuilder.Entity<BodegaProductoTecnologico>()
            .ToTable("BodegaDeTecnologia")
            .HasKey(bt => new { bt.BodegaProductoTecnologicoId });
            //Cliente con producto electrodoméstico
            modelBuilder.Entity<ClienteProductoElectrodomestico>()
           .ToTable("ClienteConElectrodomesticos")
           .HasKey(ce => new { ce.ClienteProductoElectrodomesticoId });
            //Cliente con producto tecnológico
            modelBuilder.Entity<ClienteProductoTecnologico>()
            .ToTable("ClienteConAparatoTecnologico")
            .HasKey(ct => new { ct.ClienteProductoTecnologicoId });
        }
        public DbSet<Bodega> Bodegas { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<ProductoElectrodomestico> ProductoElectrodomesticos { get; set; }
        public DbSet<ProductoTecnologico> ProductoTecnologicos { get; set; }
        public DbSet<BodegaProductoElectrodomestico> BodegaProductoElectrodomesticos { get; set; }
        public DbSet<BodegaProductoTecnologico> BodegaProductoTecnologicos { get; set; }
        public DbSet<ClienteProductoElectrodomestico> ClienteProductoElectrodomesticos { get; set; }
        public DbSet<ClienteProductoTecnologico> ClienteProductoTecnologicos { get; set; }
    }
}
