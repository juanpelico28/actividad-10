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
            Dictionary<int, string> empleados = new Dictionary<int, string>();
            int id;
            string nombre;
            Console.Write("CUANTOS EMPLEADOS DESEA INGRESAR: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("\n++++++++++++++ INGRESAR DATOS DE LOS EMPLADOS +++++++++++");

            for (int i = 0; i < num; i++)
            {
                int salir = 0;
                do
                {
                    Console.Clear();
                    Console.Write($"\nINGRESE LA ID DEL EMPLEADO {i + 1}: ");
                    id = int.Parse(Console.ReadLine());
                    if (empleados.ContainsKey(id))
                    {
                        Console.WriteLine("\nLA ID DEL EMPLEADO YA EXISTE.");
                        Console.ReadKey();
                       
                    }
                    else
                    {
                        salir = 3;
                    }
                } while (salir != 3);

                Console.WriteLine("------------- MODIFICAR ");
                Console.Write($"INGRESE LA ID DEL EMPLEADO {i + 1}: ");
                nombre = Console.ReadLine();

                empleados.Add(id, nombre);
            }
            Console.Clear();
            Console.WriteLine("\nPRODUCTOS AGREGADOS CORRECTAMENTE.");
        }
    }
}
