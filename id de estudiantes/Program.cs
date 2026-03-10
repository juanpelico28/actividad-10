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
            Dictionary<int, (string nombre, double precio)> productos = new Dictionary<int, (string, double)>();
            int  id;

            Console.WriteLine("\n++++++++++++++  DATOS DE LOS PRODUCTOS +++++++++++");
            productos.Add(12, (" YOGUR LT. ", 15));
            productos.Add(15, ("FRIJOLES LB. ", 18));
            productos.Add(17, ("LECHE NESTLE. ", 20));
            productos.Add(11, ("GELATINA. ",12));
            productos.Add(18, ("AZUCAR LB. ", 10));
            productos.Add(19, ("PAPEL PAQUETE. ", 12));
            productos.Add(20, ("SOPA INSTANTANEA. ", 5 ));
            foreach (var item in productos)
            {
                Console.WriteLine("ID: " + item.Key + " NOMBRE: " + item.Value.nombre + " PRECIO: Q" + item.Value.precio);
            }

            Console.WriteLine("\n*****ELIMINAR PRODUCTO DE LA LISTA. ***********");
            Console.Write("\nINGRESE LA ID DEL PRODUCTO: ");
            id = int.Parse(Console.ReadLine());
            
            if (productos.ContainsKey(id))
            {
                    productos.Remove(id);  
                    Console.WriteLine("SE A ELIMINADO EL PRODUCTO. ");
            }
            Console.ReadKey();
            Console.WriteLine();
            foreach(var item in productos)
            {
                Console.WriteLine("ID: "+ item.Key+ " NOMBRE: "+item.Value.nombre+ " PRECIO: Q"+ item.Value.precio);
            }
            
        }
    }
}
