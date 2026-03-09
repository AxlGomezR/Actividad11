using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func8
{
    internal class Program
    {
        static void mostrarCuadrado(int n)
        {
            Console.WriteLine($"El cuadrado de {n} es = {n*n}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número");
            int numero = int.Parse(Console.ReadLine());
            Console.Clear();
            mostrarCuadrado(numero);
        }
    }
}
