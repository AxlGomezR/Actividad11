using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func12
{
    internal class Program
    {
        static int Restar(int a, int b)
        {
            return a - b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer número");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número");
            int b = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"La resta de los números ingresados es = {Restar(a,b)}");
        }
    }
}
