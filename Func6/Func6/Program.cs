using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func6
{
    internal class Program
    {
        static void saludar(string nombre)
        {
            Console.WriteLine($"Hola {nombre}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su nombre");
            string nombre = Console.ReadLine();
            Console.Clear();
            saludar(nombre);
        }
    }
}
