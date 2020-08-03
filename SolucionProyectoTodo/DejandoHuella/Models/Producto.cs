
using System.ComponentModel.DataAnnotations;

namespace DejandoHuella.Models
{
    public abstract class Producto
    {
        [Required(ErrorMessage = "Ingrese nombre del producto")]
        [Display(Name = "Nombre del producto")]
        public string NombreProducto { get; set; }
        [Required(ErrorMessage = "Ingrese la marca")]
        [Display(Name = "Marca")]
        public string Marca { get; set; }
        [Required(ErrorMessage = "Ingrese el modelo")]
        [Display(Name = "Modelo")]
        public string Modelo { get; set; }
        [Required(ErrorMessage = "Ingrese el precio del producto")]
        [Display(Name = "Precio")]
        public float Costo { get; set; }
        [Required(ErrorMessage = "Ingrese medidas/tamaño")]
        [Display(Name = "Medidas/Tamaño")]
        public string Medidas { get; set; }
       
    }
}
