using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Venta.Modelo.Entidades
{
    public  class Cliente:Persona
    {
        [Key]
        public int ClienteId { get; set; }
        public string CedulaIdentidad { get; set; }
        public string Correo { get; set; }
        public List<ClienteProductoElectrodomestico> ClienteProductoElectrodomestico { get; set; } = new List<ClienteProductoElectrodomestico>();
        public List<ClienteProductoTecnologico> ClienteProductoTecnologico { get; set; } = new List<ClienteProductoTecnologico>();
        public Cliente(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }
        public Cliente(string nombre, string apellido,string edad,string cedula,string correo)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            CedulaIdentidad = cedula;
            Correo = correo;
        }
    }
}