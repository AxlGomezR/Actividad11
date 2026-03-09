using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func22
{
    internal class Program
    {
        static void Repetir(string texto, int repes)
        {
            for(int i=1; i<=repes; i++)
            {
                Console.WriteLine(texto);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un texto");
            string texto = Console.ReadLine();
            bool continuar = false;
            
        }
    }
}
