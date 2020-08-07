using System.ComponentModel.DataAnnotations;

namespace Venta.Modelo.Entidades
{
    public class ClienteProductoTecnologico
    {
        [Key]
        public int ClienteProductoTecnologicoId { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public int ProductoTecnologicoId { get; set; }
        public ProductoTecnologico ProductoTecnologico { get; set; }
    }
}
