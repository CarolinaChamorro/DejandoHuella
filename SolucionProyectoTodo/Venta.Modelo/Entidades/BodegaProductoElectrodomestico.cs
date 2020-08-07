using System.ComponentModel.DataAnnotations;

namespace Venta.Modelo.Entidades
{
    public class BodegaProductoElectrodomestico
    {
        [Key]
        public int BodegaProductoElectrodomesticoId { get; set; }
        public int BodegaId { get; set; }
        public Bodega Bodega { get; set; }
        public int ProductoElectrodomesticoId { get; set; }
        public ProductoElectrodomestico ProductoElectrodomestico { get; set; }

    }
}
