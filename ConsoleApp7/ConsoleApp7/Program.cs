using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class caso2factorial
    {
        static void Main(string[] args)
        {
            //Hacer un programa que pregunte un numero y calcule su factorial
            //Ejemplo: factorial de cuatro == 1*2*3*4=24


            long N;
            long factorial = 1;
            Console.Write("Mete un numero para calcular su factorial: ");
            N = long.Parse(Console.ReadLine());


            
            for (long i = 1; i <= N; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine("El factorial de " + N + " es: " + factorial);
           
        }

    }
}
