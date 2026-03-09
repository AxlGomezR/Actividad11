using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func20
{
    internal class Program
    {
        static int ContarLetras(string texto)
        {
            return texto.Length;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un texto");
            string texto = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"La cantidad de letras del texto ingresado es = {ContarLetras(texto)}");
        }
    }
}
