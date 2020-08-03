
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DejandoHuella.Models
{
    public class Bodega
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Ingrese nombre del producto")]
        [Display(Name = "Nombre del producto")]
        public string NombreProducto { get; set; }
        public int? IdEmpresa { get; set; }
        public Empresa Empresa { get; set; }
        public List<ProductoElectrodomestico> ProductoElectrodomestico { get; set; } 
        public List<ProductoTecnologico> ProductoTecnologico { get; set; }
    }
}
