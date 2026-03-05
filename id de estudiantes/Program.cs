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
            int codigo;
            string nombre;
            Console.WriteLine("++++++++++++++ INGRESAR 3 PRODUCTOS +++++++++++");
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"\nINGRESE EL CODIGO DEL PRODUCTO {i + 1}: ");
                codigo = int.Parse(Console.ReadLine());
                Console.Write($"INGRESE EL NOMBRE DEL PRODUCTO {i + 1}: ");
                nombre = Console.ReadLine();
                productos.Add(codigo, nombre);
            }
            Console.Clear();
            Console.WriteLine("\n++++++++++++++ PRODUCTOS INGRESADOS +++++++++++");
            Console.WriteLine("");
            foreach (var item in productos)
            {
                Console.WriteLine("CODIGO: " + item.Key + ", NOMBRE: " + item.Value);
            }
        }
    }
}
