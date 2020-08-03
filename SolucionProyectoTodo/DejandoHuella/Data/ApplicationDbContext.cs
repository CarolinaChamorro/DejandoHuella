using System;
using System.Collections.Generic;
using System.Text;
using DejandoHuella.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DejandoHuella.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Bodega> Bodegas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<ProductoTecnologico> ProductoTecnologicos { get; set; }
        public DbSet<ProductoElectrodomestico> ProductoElectrodomesticos { get; set; }
        public DbSet<ClienteProductoElectrodomestico> ClienteProductoElectrodomesticos { get; set; }
        public DbSet<ClienteProductoTecnologico> ClienteProductoTecnologicos { get; set; }
    }
}
