using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func10
{
    internal class Program
    {
        static void imprimirRepetido(string texto, int repe)
        {
            for(int i=1; i<=repe; i++)
            {
                Console.WriteLine(texto);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el texto que desea imprimir");
            string texto = Console.ReadLine();
            bool continuar = false;
            do
            {
                Console.WriteLine("Ingrese la cantidad de veces que desea imprimir el texto");
                int repes = int.Parse(Console.ReadLine());
                Console.Clear();
                if (repes <= 0)
                {
                    Console.WriteLine("Debe repetirse al menos una vez\n");
                }
                else
                {
                    continuar = true;
                    imprimirRepetido (texto, repes);
                }
            } while (continuar==false);
        }
    }
}
