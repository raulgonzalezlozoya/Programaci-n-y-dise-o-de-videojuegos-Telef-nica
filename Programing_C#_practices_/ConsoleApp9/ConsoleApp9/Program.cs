using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            //comprobacion de la funcion
            //Console.WriteLine(ComprobarPrimo(7));

            int numero = 2;
            int cantidadPrimos = 0;
            int[] listaPrimos = new int[100];
            while(cantidadPrimos<100)
            {
                if(ComprobarPrimo(numero))
                {
                    Console.WriteLine(numero);
                    listaPrimos[cantidadPrimos] = numero;
                    cantidadPrimos++;



                }
                numero++;

            }
            for(int i=0;i<100;i++)
            {

                Console.WriteLine(listaPrimos[i]);
            }


        }
        static bool ComprobarPrimo(int candidato)
        {

            bool esPrimo=true;

            for (int d=2;d<candidato;d++)
            {

                if (candidato%d==0)
                {

                    esPrimo = false;
                }
            }

            return esPrimo;


        }
    }
}
