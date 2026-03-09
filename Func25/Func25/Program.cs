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
        }
    }
}
