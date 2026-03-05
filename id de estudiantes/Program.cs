using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace id_de_estudiantes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> productos = new Dictionary<int, string>();
            int id;
            string nombre;
            Console.Write("CUANTOS PRODUCTOS DESEA INGRESAR: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("\n++++++++++++++ INGRESAR DATOS DE LOS PRODUCTOS +++++++++++");

            for (int i = 0; i < num; i++)
            {
                int salir = 0;
                do
                {
                    Console.Clear();
                    Console.Write($"\nINGRESE LA ID DEL PRODUCTO {i + 1}: ");
                    id = int.Parse(Console.ReadLine());
                    if(productos.ContainsKey(id))
                    {
                        Console.WriteLine("\nLA ID DEL PRODUCTO YA EXISTE.");
                        Console.ReadKey();
                       
                    }
                    else
                    {
                        salir = 3;
                    }
                } while (salir != 3);
                Console.Write($"INGRESE EL NOMBRE DEL PRODUCTO {i + 1}: ");
                nombre = Console.ReadLine();

                productos.Add(id, nombre);
            }
            Console.Clear();
            Console.WriteLine("\nPRODUCTOS AGREGADOS CORRECTAMENTE.");
        }
    }
}
