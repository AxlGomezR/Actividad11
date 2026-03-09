using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func19
{
    internal class Program
    {
        static bool EsMultiplo(int n, int m)
        {
            if (n % m == 0)
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
            Console.WriteLine("Ingrese el número que desea verificar");
            int m = int.Parse(Console.ReadLine());
            Console.Clear();
            if (EsMultiplo(n, m))
            {
                Console.WriteLine($"El número {m} es múltiplo de {n}");
            }
            else
            {
                Console.WriteLine($"El número {m} no es múltiplo de {n}");
            }
        }
    }
}
