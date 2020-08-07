using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Venta.Modelo.Entidades
{
    public class ProductoElectrodomestico:Producto
    {
        [Key]
        public int ProductoElectrodomesticoId { get; set; }
        public string ConsumoElectrico { get; set; }
        public List<BodegaProductoElectrodomestico> BodegaProductoElectrodomestico { get; set; } = new List<BodegaProductoElectrodomestico>();

        public ProductoElectrodomestico(string nombre,string marca, string modelo, float costo)
        {
            Nombre = nombre;
            Marca = marca;
            Modelo = modelo;
            Costo = costo;
        }
        public void VerListaElectro()
        {
            Console.WriteLine($"-- {this.Nombre} {this.Modelo} {this.Marca} tiene un costo de: {this.Costo}");
        }
    }
}
