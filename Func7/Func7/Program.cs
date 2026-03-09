using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func7
{
    internal class Program
    {
        static void mostrarDoble(int n)
        {
            Console.WriteLine($"El doble de {n} es = {n*2}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número");
            int numero = int.Parse( Console.ReadLine() );
            Console.Clear();
            mostrarDoble(numero);
        }
    }
}
