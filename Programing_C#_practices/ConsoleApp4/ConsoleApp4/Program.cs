using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primos
{
    class Program
    {
        static void Main(string[] args)
        {
            bool esPrimo = true;
            int N = int.Parse(Console.ReadLine());
            for (int D = 2; D < N; D++) 
            {

                if(N%D==0)
                {

                    esPrimo = false;
                    break;
                }
                if (esPrimo)
                {

                    Console.WriteLine(N + "es primo");

                }
                else
                {

                    Console.WriteLine(N + "no es primo");

                }
            }


        }
    }
}
