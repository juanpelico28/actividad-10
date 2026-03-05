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
            Dictionary<int, string> ciudades = new Dictionary<int, string>();
            int codigo ;
            string nombre;
            Console.WriteLine("++++++++++++++ INGRESAR 5 CIUDADES +++++++++++");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"\nINGRESE EL CODIGO DE LA CIUDAD {i + 1}: ");
                codigo = int.Parse(Console.ReadLine());
                Console.Write($"INGRESE EL NOMBRE DE LA CIUDAD {i + 1}: ");
                nombre = Console.ReadLine();
                ciudades.Add(codigo, nombre);
            }
            Console.Clear();
            Console.WriteLine("\n++++++++++++++ BUSCAR CIUDAD +++++++++++");
            Console.Write("INGRESE EL CODIGO DE LA CIUDAD: ");
            codigo = int.Parse(Console.ReadLine()) ;
            foreach (var item in ciudades)
            {
                if (item.Key == codigo)
                {
                    Console.WriteLine("CODIGO: " + item.Key + ", NOMBRE: " + item.Value);
                }
                
            }
        }
    }
}
