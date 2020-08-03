
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DejandoHuella.Models
{
    public class ProductoTecnologico : Producto
    {
        public ProductoTecnologico() : base()
        { }
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Ingrese la cantidad de almacenamiento")]
        [Display(Name ="Almacenamiento")]
        public string Almacenamiento { get; set; }
        [Display(Name ="Tipo de software")]
        public string TipoSoftware { get; set; }
        [Required(ErrorMessage = "Ingrese la cantidad de la memoria ram")]
        [Display(Name ="Memoria Ram")]
        public string MemoryRam { get; set; }
        public List<ClienteProductoTecnologico> ClienteProductoTecnologico { get; set; }
        public int? IdBodega { get; set; }
        public Bodega Bodega { get; set; }
        [Display(Name = "Fotografía")]
        public string FotoBase64 { get; set; }
    }
}
