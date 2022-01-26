using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordenar_array_metodo_burbuja
{
    class Program
    {
        static void Main(string[] args)
        {
            int []listaNumeros = new int[10];
                //rellenar el array con numeros introducidos
            for (int i = 0; i < 10; i++) 
            {


                Console.WriteLine("introduce un numero: ");
                listaNumeros[i] = int.Parse(Console.ReadLine());

            }

            // ordenar

            bool arraySucio = false;
            do
            {

                arraySucio = false;
                for (int i=0;i<listaNumeros.Length-1;i++)
                {
                    if (listaNumeros[i]<listaNumeros [i+1])
                    {

                        arraySucio = true;
                        int aux = listaNumeros[i];
                        listaNumeros[i] = listaNumeros[i + 1];
                        listaNumeros[i + 1] = aux;

                    }

                }


            } while (arraySucio);


            Console.WriteLine("la lista ordenada: ");
            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine(listaNumeros[i]);

            }

            }
    }
}
