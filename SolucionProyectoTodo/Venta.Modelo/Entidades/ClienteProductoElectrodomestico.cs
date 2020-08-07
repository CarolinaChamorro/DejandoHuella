using System.ComponentModel.DataAnnotations;

namespace Venta.Modelo.Entidades
{
    public class ClienteProductoElectrodomestico
    {
        [Key]
        public int ClienteProductoElectrodomesticoId { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public int ProductoElectrodomesticoId { get; set; }
        public ProductoElectrodomestico ProductoElectrodomestico { get; set; }
    }
}
