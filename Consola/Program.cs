using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Importo todas las clases del proyecto Entidades
using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Fase01");
            Console.WriteLine("Ingrese un Producto2");

            string Nombre = "Producto 01", 
                Descripcion ="",
                Proveedor ="", 
                Categoria ="", 
                SubCategoria ="";

            decimal PrecioCosto = 600;
            double Margen = 12, IVA = 21;

            Producto producto = new Producto(Nombre, Descripcion, PrecioCosto, Margen, IVA, Proveedor, Categoria, SubCategoria);
            

            Console.WriteLine("Nombre: " + producto.Nombre);
 
            Console.WriteLine("Descripcion: " + producto.Descripcion);

            Console.WriteLine("PrecioCosto: " + Convert.ToString(producto.PrecioCosto));

            Console.WriteLine("Margen: " + Convert.ToString(producto.Margen));

            Console.WriteLine("IVA: " + Convert.ToString(producto.IVA));

            Console.WriteLine("PrecioBruto: " + Convert.ToString(producto.PrecioBruto));
            Console.WriteLine("PrecioVenta: " + Convert.ToString(producto.PrecioVenta));

            Console.WriteLine("Proveedor: " + producto.Proveedor);

            Console.WriteLine("Categoria: " + producto.Categoria);
 
            Console.WriteLine("SubCategoria: "+ producto.SubCategoria);
                      



            Console.ReadLine();
        }
    }
}
