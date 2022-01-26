using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace TABLA_DE_MULTIPLICAR
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int I;
            int resultado;
            
            Console.Write("DIGITE NÚMERO:");
            N = int.Parse(Console.ReadLine());
            for (I = 1; I <= 10; I++)
            {
                resultado = N * I;
                Console.WriteLine("{0} * {1} = {2}", N, I, resultado);
            }
            Console.Write("Pulse una Tecla:"); Console.ReadLine();
        }
    }
}