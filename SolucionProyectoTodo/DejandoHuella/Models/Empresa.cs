
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DejandoHuella.Models
{
    public class Empresa
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Ingreseel nombre de la empresa")]
        [Display(Name = "Nombre de la empresa")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Ingrese el tipo de empresa")]
        [Display(Name = "Tipo de empresa")]
        public string DescripcionEmpresa { get; set; }
        public List<Bodega> Bodega { get; set; }
    }
}
