using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func5
{
    internal class Program
    {
        static void mostrarMenu()
        {
            Console.WriteLine("Seleccione una opción");
            Console.WriteLine("1) Iniciar sesión");
            Console.WriteLine("2) Salir");
            int opcion = int.Parse(Console.ReadLine());
            Console.Clear();
            if (opcion == 1)
            {
                Console.WriteLine("Sesión iniciada");
            }
            else
            {
                Console.WriteLine("Saliendo");
            }
        }
        static void Main(string[] args)
        {
            mostrarMenu();
        }
    }
}
