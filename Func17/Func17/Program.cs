using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func17
{
    internal class Program
    {
        static int Mayor(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer número");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número");
            int b = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"El valor mayor ingresado es: {Mayor(a,b)}");
        }
    }
}
