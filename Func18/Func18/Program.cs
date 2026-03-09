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
        }
    }
}
