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
            Dictionary< int,string > estudiantes = new Dictionary<int,string>();
            int id;
            string nombre;
            Console.WriteLine("++++++++++++++ INGRESAR DATOS DE 3 ESTUDIANTES +++++++++++");
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"\nINGRESE LA ID DEL ESTUDIANTE {i+1}: ");
                id = int.Parse( Console.ReadLine() );
                Console.Write($"INGRESE EL NOMBRE DEL ESTUDIANTE {i + 1}: ");
                nombre = Console.ReadLine();
                estudiantes.Add(id, nombre);
            }
            Console.Clear();
            Console.WriteLine("\n++++++++++++++ BUSCAR  ESTUDIANTES +++++++++++");
            Console.Write("INGRESE LA ID DEL ESTUDIANTE: ");
            id = int.Parse( Console.ReadLine() );

            Console.WriteLine("\n***********DATOS DE ESTUDIANTES*********");
            foreach (var item in estudiantes)
            {
                if(item.Key == id)
                {
                    Console.WriteLine("ID: "+ item.Key + ", NOMBRE: " + item.Value);
                } 
                else
                {
                    Console.WriteLine("\nNO EXISTE LA ID.");
                }
            }
        }
    }
}
