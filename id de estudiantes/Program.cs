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
            Dictionary<int, (string nombre, int ubicacion)> inventario = new Dictionary<int, (string, int)>();
            int  codigo;

            Console.WriteLine("\n++++++++++++++  DATOS DE LOS PRODUCTOS +++++++++++");
            inventario.Add(1214, ("DESTORNILLADORES DE CRUZ .  ", 1));
            inventario.Add(1545, ("LLAVES CORONA MILIMETRICAS. ", 2));
            inventario.Add(1723, ("MULTIMETRO FLUKE.           ", 3));
            inventario.Add(1156, ("AMPERIMETRO FLUKE.          ", 4));
            inventario.Add(1826, ("LLAVES ALEN MILIMETRICAS.   ", 5));
            inventario.Add(1976, ("LINTERNA MILWOKKE.          ", 6));
            inventario.Add(2001, ("COPAS MILIMETRICAS.         ", 7 ));
            foreach (var item in inventario)
            {
                Console.WriteLine("CODIGO: " + item.Key + " NOMBRE: " + item.Value.nombre + " GABETA No: " + item.Value.ubicacion);
            }

            Console.WriteLine("\n*****ELIMINAR HERRAMIENTA DE LA LISTA. ***********");
            Console.Write("\nINGRESE EL CODIGO DE LA HERRAMINETA: ");
            codigo = int.Parse(Console.ReadLine());
            
            if (inventario.ContainsKey(codigo))
            {
                    inventario.Remove(codigo);  
                    Console.WriteLine("SE A ELIMINADO LA HERRAMIENTA. ");
            }
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("\n********** LISTA ACTUALIZADA ***************");
            Console.WriteLine();
            foreach (var item in inventario)
            {
                Console.WriteLine("CODIGO: "+ item.Key+ " NOMBRE: "+item.Value.nombre+ " GABETA No: "+ item.Value.ubicacion);
            }
            
        }
    }
}
