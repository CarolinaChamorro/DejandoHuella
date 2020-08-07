
namespace Venta.Modelo.Entidades
{
    public abstract class Producto
    {
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public float Costo { get; set; }
        public string Medidas { get; set; }
    }
}
