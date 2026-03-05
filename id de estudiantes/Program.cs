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
            Dictionary<string, double> estudiantes = new Dictionary<string, double>();
            double notas;
            string nombre;
            Console.WriteLine("++++++++++++++ INGRESAR DATOS DE ESTUDIANTES +++++++++++");
            Console.Write("\nCUANTOS ESTUDIANTES DESEA INGRESAR: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                Console.Write($"\nINGRESE LA NOMBRE DEL ESTUDIANTE {i + 1}: ");
                nombre = Console.ReadLine();
                Console.Write($"INGRESE LA NOTA DEL ESTUDIANTE {i + 1}: ");
                notas = double.Parse(Console.ReadLine());

                estudiantes.Add(nombre, notas);
            }
            Console.Clear();
            Console.WriteLine("\n++++++++++++++ BUSCAR  ESTUDIANTES +++++++++++");
            Console.Write("INGRESE EL NOMBRE DEL ESTUDIANTE: ");
            nombre = Console.ReadLine();

            Console.WriteLine("\n***********DATOS DE ESTUDIANTES*********");
            foreach (var item in estudiantes)
            {
                if (item.Key == nombre)
                {
                    Console.WriteLine("ID: " + item.Key + ", NOTA: " + item.Value);
                }

            }
        }
    }
}
