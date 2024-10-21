using System;
using System.Collections.Generic;

namespace InventarioProductos
{
    internal class ActualizarStock
    {
        public static void actualizar_stock(List<string> nombres, List<float> precios, List<int> cantidades, string nombre, float nuevoPrecio, int nuevaCantidad)
        {
            int indice = nombres.IndexOf(nombre);  // Buscar el índice del producto
            if (indice != -1)
            {
                precios[indice] = nuevoPrecio;  // Actualizar el precio
                cantidades[indice] = nuevaCantidad;  // Actualizar la cantidad
                Console.WriteLine($"Producto actualizado: {nombre} - Nuevo Precio: {nuevoPrecio} - Nueva Cantidad: {nuevaCantidad}");
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }
        }
    }
}
