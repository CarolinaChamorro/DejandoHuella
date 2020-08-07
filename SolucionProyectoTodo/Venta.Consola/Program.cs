using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using Venta.Modelo;
using Venta.Modelo.Entidades;

namespace Venta.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            //Clientes
            var cliente1 = new Cliente("Vilma","Baidal");
            var cliente2 = new Cliente("Daniela", "Carrillo");
            var cliente3 = new Cliente("Lisa", "Manoban");
            var cliente4 = new Cliente("Alejandra", "López");
            var cliente5 = new Cliente("Lauren", "Jauregui");
            var cliente6 = new Cliente("Camila", "Cabello");
            var cliente7 = new Cliente("Paola", "Campos");
            var cliente8 = new Cliente("Anastasia", "Inglaterra");

            //Productos electrodomésticos
            var produElectro1 = new ProductoElectrodomestico("SmartTv","LG", "Electronics 65UK6300PUE", 1048);
            var produElectro2 = new ProductoElectrodomestico("Cocina", "Global", "ARU017", 271);
            var produElectro3 = new ProductoElectrodomestico("Lavadora", "Whirlpool", "WWI16BSHLA", 429);
            var produElectro4 = new ProductoElectrodomestico("Refrigeradora", "Indurama", "RI-780I", 846);
            var produElectro5 = new ProductoElectrodomestico("Campana extractora convencional", "Indurama", "CEI-75CRP", 145);
            //Productos tecnológicos
            var produTecno1 = new ProductoTecnologico("SmartPhone", "Samsung", "S9", 530);
            var produTecno2 = new ProductoTecnologico("SmartWatch", "Xiaomi", "BandS3", 30);
            var produTecno3 = new ProductoTecnologico("SmartPhone", "Xiaomi", "Note8Pro", 230);
            var produTecno4 = new ProductoTecnologico("AirPhones", "Apple", "AirPodsPro", 153);
            var produTecno5 = new ProductoTecnologico("Parlante", "Bose", "SoundLink", 99);

            var unicoInventario = new Inventario();
            
            //Stock electrodoméstico
            unicoInventario.ContarStockProductoElectrodomestico(produElectro1);
            unicoInventario.ContarStockProductoElectrodomestico(produElectro2);
            unicoInventario.ContarStockProductoElectrodomestico(produElectro3);
            unicoInventario.ContarStockProductoElectrodomestico(produElectro4);
            unicoInventario.ContarStockProductoElectrodomestico(produElectro5);
            //Stock tecnologico
            unicoInventario.ContarStockProductoTecnologico(produTecno1);
            unicoInventario.ContarStockProductoTecnologico(produTecno2);
            unicoInventario.ContarStockProductoTecnologico(produTecno3);
            unicoInventario.ContarStockProductoTecnologico(produTecno4);
            unicoInventario.ContarStockProductoTecnologico(produTecno1);

            //Ventas de electrodomesticos
            unicoInventario.ContarVentasElectrodomesticos(cliente1, produElectro1);
            unicoInventario.ContarVentasElectrodomesticos(cliente5, produElectro3);
            unicoInventario.ContarVentasElectrodomesticos(cliente2, produElectro2);
            unicoInventario.ContarVentasElectrodomesticos(cliente6, produElectro5);
            unicoInventario.ContarVentasElectrodomesticos(cliente1, produElectro4);
            unicoInventario.ContarVentasElectrodomesticos(cliente7, produElectro2);
            unicoInventario.ContarVentasElectrodomesticos(cliente2, produElectro1);
            unicoInventario.ContarVentasElectrodomesticos(cliente3, produElectro5);
            unicoInventario.ContarVentasElectrodomesticos(cliente8, produElectro2);
            unicoInventario.ContarVentasElectrodomesticos(cliente6, produElectro5);
            unicoInventario.ContarVentasElectrodomesticos(cliente4, produElectro4);
            

            //Ventas Tecnologicas
            unicoInventario.ContarVentasTecnologicas(cliente4, produTecno1);
            unicoInventario.ContarVentasTecnologicas(cliente5, produTecno3);
            unicoInventario.ContarVentasTecnologicas(cliente6, produTecno2);
            unicoInventario.ContarVentasTecnologicas(cliente7, produTecno5);
            unicoInventario.ContarVentasTecnologicas(cliente8, produTecno4);
            unicoInventario.ContarVentasTecnologicas(cliente1, produTecno2);
            unicoInventario.ContarVentasTecnologicas(cliente4, produTecno1);
            unicoInventario.ContarVentasTecnologicas(cliente3, produTecno5);
            unicoInventario.ContarVentasTecnologicas(cliente2, produTecno2);
            unicoInventario.ContarVentasTecnologicas(cliente5, produTecno5);
            unicoInventario.ContarVentasTecnologicas(cliente3, produTecno4);
            
            //valores
            var valorElectro=unicoInventario.VentasElectrodomesticos;
            var valorTecno = unicoInventario.VentasTecnologicas;
            var stockElectro = unicoInventario.StockElectrodomesticos;
            var stockTecno = unicoInventario.StockTecnologico;
            //Lista de producto tecnologico
            List<ProductoTecnologico> ListaTecnologica = new List<ProductoTecnologico>();
            ListaTecnologica.Add(produTecno1);
            ListaTecnologica.Add(produTecno2);
            ListaTecnologica.Add(produTecno3);
            ListaTecnologica.Add(produTecno4);
            ListaTecnologica.Add(produTecno5);
            //Lista de producto electrodomestico
            List<ProductoElectrodomestico> ListaElectrodomestica = new List<ProductoElectrodomestico>();
            ListaElectrodomestica.Add(produElectro1);
            ListaElectrodomestica.Add(produElectro2);
            ListaElectrodomestica.Add(produElectro3);
            ListaElectrodomestica.Add(produElectro4);
            ListaElectrodomestica.Add(produElectro5);

            
            Console.WriteLine($"------------------------------------------------------");
            Console.WriteLine($"\tSimulación de Inventario de una empresa");
            Console.WriteLine($"------------------------------------------------------");
            Console.WriteLine("Ingrese su nombre");
            var nombreCliente = Console.ReadLine();
            Console.WriteLine($"*Bienvenido/a {nombreCliente}");
            //Opciones inventario
            Console.WriteLine("¿Qué opción escoges?: ");
            Console.WriteLine("\ta - Venta de productos electrodomesticos + clientes");
            Console.WriteLine("\tb - Venta de productos tecnológicos + clientes");
            Console.WriteLine("\tc - Productos electrodoméstico en stock");
            Console.WriteLine("\td - Productos tecnológicos en stock");
            //Respuestas
            var respuesta = Console.ReadLine();
            if (respuesta=="a")//Venta de productos electrodomesticos + clientes
            {
                Console.WriteLine($"El cliente {cliente1.Nombre} {cliente1.Apellido} ha comprado {produElectro1.Nombre} {produElectro1.Marca} " +
               $"{produElectro1.Modelo} en {produElectro1.Costo}");
                Console.WriteLine($"El cliente {cliente5.Nombre} {cliente5.Apellido} ha comprado {produElectro3.Nombre} {produElectro3.Marca} " +
               $"{produElectro3.Modelo} en {produElectro3.Costo}");
                Console.WriteLine($"El cliente {cliente2.Nombre} {cliente2.Apellido} ha comprado {produElectro2.Nombre} {produElectro2.Marca} " +
               $"{produElectro2.Modelo} en {produElectro2.Costo}");
                Console.WriteLine($"El cliente {cliente6.Nombre} {cliente6.Apellido} ha comprado {produElectro5.Nombre} {produElectro5.Marca} " +
               $"{produElectro5.Modelo} en {produElectro5.Costo}");
                Console.WriteLine($"El cliente {cliente1.Nombre} {cliente1.Apellido} ha comprado {produElectro4.Nombre} {produElectro4.Marca} " +
               $"{produElectro4.Modelo} en {produElectro4.Costo}");
                Console.WriteLine($"El cliente {cliente7.Nombre} {cliente7.Apellido} ha comprado {produElectro2.Nombre} {produElectro2.Marca} " +
               $"{produElectro2.Modelo} en {produElectro2.Costo}");
                Console.WriteLine($"El cliente {cliente2.Nombre} {cliente2.Apellido} ha comprado {produElectro1.Nombre} {produElectro1.Marca} " +
               $"{produElectro1.Modelo} en {produElectro1.Costo}");
                Console.WriteLine($"El cliente {cliente3.Nombre} {cliente3.Apellido} ha comprado {produElectro5.Nombre} {produElectro5.Marca} " +
               $"{produElectro5.Modelo} en {produElectro5.Costo}");
                Console.WriteLine($"El cliente {cliente8.Nombre} {cliente8.Apellido} ha comprado {produElectro2.Nombre} {produElectro2.Marca} " +
               $"{produElectro2.Modelo} en {produElectro2.Costo}");
                Console.WriteLine($"El cliente {cliente6.Nombre} {cliente6.Apellido} ha comprado {produElectro5.Nombre} {produElectro5.Marca} " +
               $"{produElectro5.Modelo} en {produElectro5.Costo}");
                Console.WriteLine($"El cliente {cliente4.Nombre} {cliente4.Apellido} ha comprado {produElectro4.Nombre} {produElectro4.Marca} " +
               $"{produElectro4.Modelo} en {produElectro4.Costo}");
                Console.WriteLine($"------------------------------------------------------");
                Console.WriteLine($"Hay {valorElectro} clientes que han comprado productos electrodomésticos");
                Console.WriteLine($"------------------------------------------------------");
            }
            else if (respuesta == "b")//Venta de productos tecnológicos + clientes
            {
                Console.WriteLine($"El cliente {cliente4.Nombre} {cliente4.Apellido} ha comprado {produTecno1.Nombre} {produTecno1.Marca} " +
            $"{produTecno1.Modelo} en {produTecno1.Costo}");
                Console.WriteLine($"El cliente {cliente5.Nombre} {cliente5.Apellido} ha comprado {produTecno3.Nombre} {produTecno3.Marca} " +
               $"{produTecno3.Modelo} en {produTecno3.Costo}");
                Console.WriteLine($"El cliente {cliente6.Nombre} {cliente6.Apellido} ha comprado {produTecno2.Nombre} {produTecno2.Marca} " +
               $"{produTecno2.Modelo} en {produTecno2.Costo}");
                Console.WriteLine($"El cliente {cliente7.Nombre} {cliente7.Apellido} ha comprado {produTecno5.Nombre} {produTecno5.Marca} " +
               $"{produTecno5.Modelo} en {produTecno5.Costo}");
                Console.WriteLine($"El cliente {cliente8.Nombre} {cliente8.Apellido} ha comprado {produTecno4.Nombre} {produTecno4.Marca} " +
               $"{produTecno4.Modelo} en {produTecno4.Costo}");
                Console.WriteLine($"El cliente {cliente1.Nombre} {cliente1.Apellido} ha comprado {produTecno2.Nombre} {produTecno2.Marca} " +
               $"{produTecno2.Modelo} en {produTecno2.Costo}");
                Console.WriteLine($"El cliente {cliente4.Nombre} {cliente4.Apellido} ha comprado {produTecno1.Nombre} {produTecno1.Marca} " +
               $"{produTecno1.Modelo} en {produTecno1.Costo}");
                Console.WriteLine($"El cliente {cliente3.Nombre} {cliente3.Apellido} ha comprado {produTecno5.Nombre} {produTecno5.Marca} " +
               $"{produTecno5.Modelo} en {produTecno5.Costo}");
                Console.WriteLine($"El cliente {cliente2.Nombre} {cliente2.Apellido} ha comprado {produTecno2.Nombre} {produTecno2.Marca} " +
               $"{produTecno2.Modelo} en {produTecno2.Costo}");
                Console.WriteLine($"El cliente {cliente5.Nombre} {cliente5.Apellido} ha comprado {produTecno5.Nombre} {produTecno5.Marca} " +
               $"{produTecno5.Modelo} en {produTecno5.Costo}");
                Console.WriteLine($"El cliente {cliente3.Nombre} {cliente3.Apellido} ha comprado {produTecno4.Nombre} {produTecno4.Marca} " +
               $"{produTecno4.Modelo} en {produTecno4.Costo}");
                Console.WriteLine($"------------------------------------------------------");
                Console.WriteLine($"Hay {valorTecno} clientes que han comprado productos tecnológicos");
                Console.WriteLine($"------------------------------------------------------");

            }
            else if (respuesta == "c")
            {
                foreach (ProductoElectrodomestico item in ListaElectrodomestica)
                {
                    item.VerListaElectro();
                }
                Console.WriteLine($"Hay en stock {stockElectro} productos electrodoméstico");
            }
            else if (respuesta=="d")
            {
                foreach (ProductoTecnologico item in ListaTecnologica)
                {
                    item.VerListaTecno();
                }
                Console.WriteLine($"Hay en stock {stockTecno} productos tecnológicos");
            }

            

           
            

        }
    }
}
