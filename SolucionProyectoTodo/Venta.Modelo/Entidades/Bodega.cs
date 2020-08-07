using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Venta.Modelo.Entidades
{
    public class Bodega
    {
        [Key]
        public int BodegaId { get; set; }
        public string NombreSeccion { get; set; }
        public int EmpresaId { get; set; }
        public Empresa Empresa { get; set; }
        public List<BodegaProductoElectrodomestico> BodegaProductoElectrodomestico { get; set; } = new List<BodegaProductoElectrodomestico>();
        public List<BodegaProductoTecnologico> BodegaProductoTecnologico { get; set; } = new List<BodegaProductoTecnologico>();
    }
}
