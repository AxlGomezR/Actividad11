using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func25
{
    internal class Program
    {
        static bool EsPrimo(int n)
        {
            bool primo = true;
            for(int i =2; i<n; i++)
            {
                if (n % i == 0)
                {
                    primo = false;
                    break;
                }
            }
            return primo;
        }
        static void Main(string[] args)
        {
            bool continuar = false;
            int n;
            do {
                Console.WriteLine("Ingrese un número");
                n = int.Parse(Console.ReadLine());
                Console.Clear();
                if (n >= 2)
                {
                    continuar = true;
                }
                else
                {
                    Console.WriteLine("Debe ingresar un número mayor a 1");
                }
            } while (continuar==false);
            if (EsPrimo(n))
            {
                Console.WriteLine($"El número {n} es primo");
            }
            else
            {
                Console.WriteLine($"El número {n} no es primo");
            }
        }
    }
}
