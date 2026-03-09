using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func18
{
    internal class Program
    {
        static int MayorDeTres(int a, int b, int c)
        {
            int mayor = a;
            if (b > mayor)
            {
                mayor = b;
            }
            if (c > mayor)
            {
                mayor = c;
            }
            return mayor;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer número");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número");
            int b= int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer número");
            int c = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"El número mayor de los tres es = {MayorDeTres(a,b,c)}");
        }
    }
}
