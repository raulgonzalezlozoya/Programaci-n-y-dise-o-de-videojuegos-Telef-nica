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
            numero = int.Parse(texto);            if (numero > 100)
            {
                Console.WriteLine("es mayor que 100");
                


            }
            if (numero < 100)
            {

                Console.WriteLine("es menor que 100");
            }
            if (numero == 100)
            {
                Console.WriteLine("es igual que 100");
            }
        }
    }
}
