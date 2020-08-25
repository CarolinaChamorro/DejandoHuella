using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Venta.Modelo.Entidades
{
    public class ProductoTecnologico : Producto
    {
        [Key]
        public int ProductoTecnologicoId { get; set; }
        public string Almacenamiento { get; set; }
        public string TipoSoftware { get; set; }
        public string MemoryRam { get; set; }
        public List<BodegaProductoTecnologico> BodegaProductoTecnologico { get; set; } = new List<BodegaProductoTecnologico>();

        public ProductoTecnologico(string nombre, string marca, string modelo, float costo)
        {
            Nombre = nombre;
            Marca = marca;
            Modelo = modelo;
            Costo = costo;
        }
        public ProductoTecnologico(string nombre, string marca, string modelo, float costo,string medidas,string almacenamiento,string software,string memory)
        {
            Nombre = nombre;
            Marca = marca;
            Modelo = modelo;
            Costo = costo;
            Medidas = medidas;
            Almacenamiento = almacenamiento;
            TipoSoftware = software;
            MemoryRam = memory;
        }
        public void VerListaTecno()
        {
            Console.WriteLine($"-- {this.Nombre} {this.Modelo} {this.Marca} tiene un costo de: {this.Costo}");
        }
    }
}
