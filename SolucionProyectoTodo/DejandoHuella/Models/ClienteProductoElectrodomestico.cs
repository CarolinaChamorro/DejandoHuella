
namespace DejandoHuella.Models
{
    public class ClienteProductoElectrodomestico
    {
        public int Id { get; set; }
        public int? IdCliente { get; set; }
        public Cliente Cliente { get; set; }
        public int? IdProductoElectrodomestico { get; set; }
        public ProductoElectrodomestico ProductoElectrodomestico { get; set; }
    }
}
