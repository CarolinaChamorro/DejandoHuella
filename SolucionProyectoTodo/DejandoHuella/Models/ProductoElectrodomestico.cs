using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DejandoHuella.Models
{
    public class ProductoElectrodomestico:Producto
    {
        public ProductoElectrodomestico() : base()
        {
        }
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Ingrese el consumo eléctrico")]
        [Display(Name ="Consumo eléctrico")]
        public string ConsumoElectrico { get; set; }
        public List<ClienteProductoElectrodomestico> ClienteProductoElectrodomestico { get; set; }
        public int? IdBodega { get; set; }
        public Bodega Bodega { get; set; }
        [Display(Name ="Fotografía")]
        public string FotoBase64 { get; set; }
    }
}
