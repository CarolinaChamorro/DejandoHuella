using DejandoHuella.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DejandoHuella.ViewModels
{
    public class ProductoTecnologicoViewModel:ProductoViewModel
    {
        public ProductoTecnologicoViewModel():base()
        {

        }
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Ingrese la cantidad de almacenamiento")]
        [Display(Name = "Almacenamiento")]
        public string Almacenamiento { get; set; }
        [Display(Name = "Tipo de software")]
        public string TipoSoftware { get; set; }
        [Required(ErrorMessage = "Ingrese la cantidad de la memoria ram")]
        [Display(Name = "Memoria Ram")]
        public string MemoryRam { get; set; }
        public List<ClienteProductoTecnologico> ClienteProductoTecnologico { get; set; }
        public int? IdBodega { get; set; }
        public Bodega Bodega { get; set; }
        [Required(ErrorMessage = "Escoge una imagen")]
        [Display(Name = "Fotografía")]
        public IFormFile FotoBase64 { get; set; }

    }
}
