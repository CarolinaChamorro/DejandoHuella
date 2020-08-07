using System.ComponentModel.DataAnnotations;

namespace Venta.Modelo.Entidades
{
    public class BodegaProductoTecnologico
    {
        [Key]
        public int BodegaProductoTecnologicoId { get; set; }
        public int BodegaId { get; set; }
        public Bodega Bodega { get; set; }
        public int ProductoTecnologicoId { get; set; }
        public ProductoTecnologico ProductoTecnologico { get; set; }
    }
}
