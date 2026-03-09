using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func9
{
    internal class Program
    {
        static void sumarMostrar(int a, int b)
        {
            Console.WriteLine($"{a} + {b} = {a+b}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer número");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número");
            int b = int.Parse(Console.ReadLine());
            Console.Clear();
            sumarMostrar(a, b);
        }
    }
}
