using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func15
{
    internal class Program
    {
        static bool EsPar(int n)
        {
            if (n%2==0)
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
            if (EsPar(n))
            {
                Console.WriteLine("El número ingresado es par");
            }
            else
            {
                Console.WriteLine("El número ingresado no es par");
            }
        }
    }
}
