using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func21
{
    internal class Program
    {
        static int ContarVocales(string texto)
        {
            int vocales=0;
            texto = texto.ToLower();
            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] == 'a' || texto[i] == 'e' || texto[i] == 'i' || texto[i] == 'o' || texto[i] == 'u')
                {
                    vocales++;
                }
            }
            return vocales;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un texto");
            string texto = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"La cantidad de vocales en el texto ingresado es de = {ContarVocales(texto)}");
        }
    }
}
