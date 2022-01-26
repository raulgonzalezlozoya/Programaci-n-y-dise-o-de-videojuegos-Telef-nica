using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto;
            int numero;
            Console.Write("Introduce un número: ");
            texto = Console.ReadLine();
            numero = int.Parse(texto);            int n = numero;            if (n % 2 == 0)
            {
                Console.WriteLine("es par");



            }
            else 
                    {

                Console.WriteLine("es impar");
            }
        }
    }
}
