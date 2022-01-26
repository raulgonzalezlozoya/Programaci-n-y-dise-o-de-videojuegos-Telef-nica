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
            numero = int.Parse(texto);            int A = numero * numero;            Console.WriteLine("El doble es: " A);
            
            
        }
    }
}
