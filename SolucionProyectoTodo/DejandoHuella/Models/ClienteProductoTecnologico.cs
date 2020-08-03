
namespace DejandoHuella.Models
{
    public class ClienteProductoTecnologico
    {
        public int? Id { get; set; }
        public Cliente Cliente { get; set; }
        public int? IdProductoTecnologico { get; set; }
        public ProductoTecnologico ProductoTecnologico { get; set; }
    }
}
