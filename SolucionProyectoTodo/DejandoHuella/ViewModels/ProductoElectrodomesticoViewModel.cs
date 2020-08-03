using DejandoHuella.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DejandoHuella.ViewModels
{
    public class ProductoElectrodomesticoViewModel : ProductoViewModel
    {
        public ProductoElectrodomesticoViewModel() : base()
        {
        }
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Ingrese el consumo eléctrico")]
        [Display(Name = "Consumo eléctrico")]
        public string ConsumoElectrico { get; set; }
        public List<ClienteProductoElectrodomestico> ClienteProductoElectrodomestico { get; set; }
        public int? IdBodega { get; set; }
        public Bodega Bodega { get; set; }
        [Required(ErrorMessage = "Escoge una imagen")]
        [Display(Name = "Fotografía")]
        public IFormFile FotoBase64 { get; set; }
    }
}
