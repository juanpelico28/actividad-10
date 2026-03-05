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
            Dictionary<string, string> usuarios = new Dictionary<string, string>();
            string contraseña;
            string usuario;
           
            Console.Write("CUANTOS USUARIOS DESEA INGRESAR : ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("\n++++++++++++++ INGRESAR DATOS DE USUARIO +++++++++++");
            for (int i = 0; i < num; i++)
            {
                Console.Write($"\nINGRESE USUARIO {i + 1}: ");
                usuario = Console.ReadLine();
                Console.Write($"INGRESE LA CONTRASEÑA DEL USUARIO {i + 1}: ");
                contraseña = Console.ReadLine();

                usuarios.Add(usuario, contraseña);
            }
            Console.Clear();
            Console.WriteLine("\n++++++++++++++ DESPLEGAR CONTRASEÑA +++++++++++");
            Console.Write("INGRESE EL USUARIO: ");
            usuario = Console.ReadLine();
            foreach (var item in usuarios)
            {
                if (item.Key == usuario)
                {
                    Console.WriteLine("\nCONTRASEÑA: " + item.Value);
                }

            }
        }
    }
}
