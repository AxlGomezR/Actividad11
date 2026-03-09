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
            int repes;
            do
            {
                Console.WriteLine("Ingrese la cantidad de veces que desea imprimir el texto");
                repes = int.Parse(Console.ReadLine());
                Console.Clear();
                if (repes <= 0)
                {
                    Console.WriteLine("El texto debe imprimirse al menos una vez\n");
                }
                else
                {
                    continuar = true;
                }
            } while (continuar == false);
            Repetir(texto, repes);
        }
    }
}
