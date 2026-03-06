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
            double id;
            string nombre;
            
            Console.WriteLine("\n++++++++++++++  DATOS ESTUDIANTES +++++++++++");
            estudiantes.Add("juan", 87);
            estudiantes.Add("pedro",90 );
            estudiantes.Add("jose", 87);
            estudiantes.Add("roberto", 75);
            estudiantes.Add("mario", 66);
            estudiantes.Add("carlos", 78);
            Console.WriteLine("\nEMPLEADOS AGREGADOS CORRECTAMENTE.");
            Console.Write("\nINGRESE ELL NOMBRE DEL ESTUDIANTE: ");
            nombre = Console.ReadLine();
            foreach (var item in estudiantes)
            {
                if (estudiantes.ContainsKey(nombre))
                {
                    Console.WriteLine("EL NOMBRE SI EXISTE. ");
                    Console.WriteLine("NOMBRE: " + item.Key + "/ NOTA: " + item.Value);

                }
            }
            Console.ReadKey();
        }
    }
}
