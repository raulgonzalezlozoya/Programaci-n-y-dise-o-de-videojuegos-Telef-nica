using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto;
            int numero;
            Console.Write("Introduce un número: ");
            texto = Console.ReadLine();
            numero = int.Parse(texto);            if (numero >= 0)
            {
                Console.WriteLine("positivo");


            }
            if (numero < 0)
            {

                Console.WriteLine("negativo");
            }
        }
    }
}
