using System;
using System.Collections.Generic;

namespace InventarioProductos
{
    internal class AgregarProductos
    {
        public static void agregarProductos(List<string> nombres, List<float> precios, List<int> cantidades, string nombre, float precio, int cantidad)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(nombre))
                {
                    throw new ArgumentException("El nombre no puede estar vacío.");
                }
                if (precio < 0)
                {
                    throw new ArgumentException("El precio no puede ser negativo.");
                }
                if (cantidad < 0)
                {
                    throw new ArgumentException("La cantidad no puede ser negativa.");
                }

                // Agregar los datos a las listas
                nombres.Add(nombre);
                precios.Add(precio);
                cantidades.Add(cantidad);
                Console.WriteLine($"Producto agregado: {nombre} - Precio: {precio} - Cantidad: {cantidad}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
