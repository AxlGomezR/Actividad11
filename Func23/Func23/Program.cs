using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func23
{
    internal class Program
    {
        static int SumarDel1AlN(int n)
        {
            int suma = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Ingrese el número {i}");
                int numero= int.Parse( Console.ReadLine() );
                suma += numero;
            }
            return suma;
        }
        static void Main(string[] args)
        {
            
        }
    }
}
