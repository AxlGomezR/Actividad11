using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func14
{
    internal class Program
    {
        static double Dividir(double a, double b)
        {
            return a / b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer número");
            double a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número");
            double b = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"La división de los números ingresados es = {Dividir(a,b)}");
        }
    }
}
