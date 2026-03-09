using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func24
{
    internal class Program
    {
        static int Factorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            return fact;
        }
        static void Main(string[] args)
        {
            bool continuar = false;
            int n;
            do
            {
                Console.WriteLine("Ingrese un número");
                n = int.Parse(Console.ReadLine());
                Console.Clear();
                if (n >= 0)
                {
                    continuar = true;
                }
                else
                {
                    Console.WriteLine("Debe ingresar un número mayor o igual a 0");
                }
            } while (continuar==false);
            Console.WriteLine($"El factorial de {n} es = {Factorial(n)}");
        }
    }
}
