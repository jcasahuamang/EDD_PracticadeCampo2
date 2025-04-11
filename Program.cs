using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticadeCampo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaProductos lista = new ListaProductos();

            // AÑADIENDO PRODUCTOS
            lista.Insertar(new Productos(200, "Laptop Lenovo", 10, 2400, true));
            lista.Insertar(new Productos(100, "Laptop hp", 10, 3500, true));
            lista.Insertar(new Productos(400, "Laptop Asus", 10, 3400, true));
            lista.Insertar(new Productos(300, "Laptop Dell", 10, 4400, true));
            lista.Insertar(new Productos(500, "Laptop Apple", 10, 5400, true));
            //LISTAR PRODUCTOS 
            lista.Listar();
            Console.Write("\n");
            // BUSCAR PRODUCTO
            Console.WriteLine("\n--- BUSQUANDO PRODUCTOS ---");
            lista.Buscar(200);
            lista.Buscar(700);
            // ELIMINAR PRODUCTO
            Console.WriteLine("\n--- ELIMINANDO PRODUCTOS ---");
            lista.Eliminar(300);
            lista.Listar();
            // ORDENAR PRODUCTOS
            Console.WriteLine("\n--- ORDENANDO PRODUCTOS ---");
            lista.Ordenar();
            lista.Listar();
            Console.ReadLine();

        }
    }
}
