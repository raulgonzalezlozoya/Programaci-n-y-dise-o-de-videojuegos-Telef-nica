using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutoria
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] listaNumeros = new int[] { 2, 3, 5, 7, 11, 13 };


            Console.WriteLine("introduce un numero: ");
            int numero = int.Parse(Console.ReadLine());

            bool encontrado = false;
            for(int i=0;i<listaNumeros.Length;i++)
            {

                if(listaNumeros[i]==numero)
                {

                    encontrado == true;
                }



            }
            if (encontrado)
            {

                Console.WriteLine("el numero estaba en array")
            }

        }
    }
}
