using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func11
{
    internal class Program
    {
        static int Sumar(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer número");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número");
            int num2 = int.Parse(Console.ReadLine());
            Console.Clear();
            int suma = Sumar(num1, num2);
            Console.WriteLine($"La suma de los números ingresados es = {suma}");
        }
    }
}
