using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func23
{
    internal class Program
    {
        static void SumarDel1AlN(int n)
        {
            int suma = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Ingrese el número {i}");
                int numero= int.Parse( Console.ReadLine() );
                suma += numero;
            }
            Console.WriteLine($"La suma de los números ingresados es {suma}");
        }
        static void Main(string[] args)
        {
            int n;
            bool continuar = false;
            do
            {
                Console.WriteLine("Ingrese la cantidad de números que desea sumar");
                n = int.Parse(Console.ReadLine());
                Console.Clear();
                if (n > 0)
                {
                    continuar = true;
                }
                else
                {
                    Console.WriteLine("Debe ingresar al menos un número\n");
                }
            } while (continuar == false);
            SumarDel1AlN(n);
        }
    }
}
