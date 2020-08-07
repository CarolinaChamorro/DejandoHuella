using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Venta.Modelo.Entidades
{
    public class Empresa
    {
        [Key]
        public int EmpresaId { get; set; }
        public string Nombre { get; set; }
        public string DescripcionEmpresa { get; set; }
        public List<Bodega> Bodega { get; set; } = new List<Bodega>();
    }
}
