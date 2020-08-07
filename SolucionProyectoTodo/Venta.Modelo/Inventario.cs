using Venta.Modelo.Entidades;

namespace Venta.Modelo
{
    public class Inventario
    {
        public int VentasElectrodomesticos { get; set; }
        public int VentasTecnologicas { get; set; }
        public int StockElectrodomesticos { get; set; }
        public int StockTecnologico { get; set; }
        public void ContarVentasElectrodomesticos(Cliente cliente, ProductoElectrodomestico productoElectrodomestico)
        {
            cliente.ClienteProductoElectrodomestico.Add(new ClienteProductoElectrodomestico { 
            ProductoElectrodomestico=productoElectrodomestico,
            Cliente=cliente
            });
            VentasElectrodomesticos++;
        }
        public void ContarVentasTecnologicas(Cliente cliente, ProductoTecnologico productoTecnologico)
        {
            cliente.ClienteProductoTecnologico.Add(new ClienteProductoTecnologico { 
            ProductoTecnologico=productoTecnologico,
            Cliente=cliente
            });
            VentasTecnologicas++;
        }
        public void ContarStockProductoElectrodomestico(ProductoElectrodomestico productoElectrodomestico)
        {
            productoElectrodomestico.BodegaProductoElectrodomestico.Add(new BodegaProductoElectrodomestico { 
            ProductoElectrodomestico=productoElectrodomestico
            });
            StockElectrodomesticos++;
        }
        public void ContarStockProductoTecnologico(ProductoTecnologico productoTecnologico)
        {
            productoTecnologico.BodegaProductoTecnologico.Add(new BodegaProductoTecnologico
            {
                ProductoTecnologico = productoTecnologico
            });
            StockTecnologico++;
        }

    }
}
