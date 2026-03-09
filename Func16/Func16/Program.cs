using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func16
{
    internal class Program
    {
        static bool EsPositivo(int n)
        {
            if (n > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número");
            int n = int.Parse(Console.ReadLine());
            Console.Clear();
            if (EsPositivo(n))
            {
                Console.WriteLine("El número ingresado es positivo");
            }
            else
            {
                Console.WriteLine("El número ingresado no es positivo");
            }
        }
    }
}
