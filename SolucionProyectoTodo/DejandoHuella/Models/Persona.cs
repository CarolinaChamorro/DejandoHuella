
using System.ComponentModel.DataAnnotations;

namespace DejandoHuella.Models
{
    public class Persona
    {
        [Required(ErrorMessage = "Ingrese su nombre")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Ingrese su apellido")]
        [Display(Name = "Apellido")]
        public string Apellido { get; set; }
        [Display(Name = "Edad")]
        public string Edad { get; set; }
    }
}
