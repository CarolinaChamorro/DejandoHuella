using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DejandoHuella.Models
{
    public  class Cliente:Persona
    {
        public Cliente() : base()
        {
        }
        [Key]
        public int Id { get; set; }
        [Display(Name = "Cédula de identidad")]
        public string CedulaIdentidad { get; set; }
        [Display(Name = "Correo eletrónico")]
        public string Correo { get; set; }
        public List<ClienteProductoElectrodomestico> ClienteProductoElectrodomestico { get; set; }
        public List<ClienteProductoTecnologico> ClienteProductoTecnologico { get; set; }
    }
}