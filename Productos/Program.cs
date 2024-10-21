using System;
using System.Collections.Generic;

namespace InventarioProductos
{
    internal class Program
    {
        // Listas globales en la clase principal para almacenar los datos de los productos
        static List<string> nombres = new List<string>();
        static List<float> precios = new List<float>();
        static List<int> cantidades = new List<int>();

        static void Main(string[] args)
        {
            int opc;
            do
            {
                Console.WriteLine("Digite la opción deseada:");
                Console.WriteLine("1. Agregar Producto\n2. Actualizar stock\n3. Ver valor total de inventario");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    // Agregar producto
                    case 1:
                        AgregarProducto();
                        break;

                    // Actualizar stock
                    case 2:
                        actualizarStock();
                        break;

                    // Ver valor total del inventario
                    case 3:
                        MostrarStock();
                        break;

                    // Calcular valor total del inventario
                    case 4:
                        CalcularValorTotal();
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

                Console.WriteLine(); // Espacio entre opciones
            } while (opc != 0);
        }

        // Función para solicitar los datos de un nuevo producto y agregarlo
        static void AgregarProducto()
        {
            string nombre;
            float precio;
            int cantidad;

            Console.WriteLine("Ingrese el nombre del producto:");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el precio del producto:");
            precio = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad del producto:");
            cantidad = int.Parse(Console.ReadLine());

            // Llamada a la función para agregar el producto a las listas
            AgregarProductos.agregarProductos(nombres, precios, cantidades, nombre, precio, cantidad);
        }

        // Función para actualizar el stock de un producto existente
        static void actualizarStock()
        {
            string nombre;
            float nuevoPrecio;
            int nuevaCantidad;

            Console.WriteLine("Ingrese el nombre del producto que desea actualizar:");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el nuevo precio del producto:");
            nuevoPrecio = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la nueva cantidad del producto:");
            nuevaCantidad = int.Parse(Console.ReadLine());

            // Llamada a la función para actualizar el stock
            ActualizarStock.actualizar_stock(nombres, precios, cantidades, nombre, nuevoPrecio, nuevaCantidad);
        }

        // Función para mostrar el inventario actual
        static void MostrarStock()
        {
            Console.WriteLine("\nInventario actual:");
            for (int i = 0; i < nombres.Count; i++)
            {
                Console.WriteLine($"Producto: {nombres[i]} - Precio: {precios[i]} - Cantidad: {cantidades[i]}");
            }
        }
        static void CalcularValorTotal()
        {
            float valorTotal = 0;

            for (int i = 0; i < nombres.Count; i++)
            {
                valorTotal += precios[i] * cantidades[i];
            }

            Console.WriteLine($"\nEl valor total del inventario es: {valorTotal}");
        }
    }
}
