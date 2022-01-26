using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crear_un_array_con_los_nombres_de_los_planetas
{
    class Program
    {
        static void Main(string[] args)
        {

            //arrays
            int[] listaNumeros;
            listaNumeros = new int[5];
            Console.WriteLine("introduce cinco numeros: ");

            for(int i=0;i<5;i++)
            {

                listaNumeros[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("contenido del array: ");
            for (int i=0;i<5;i++)
            {

                Console.WriteLine(listaNumeros[i]);


            }
            

        }
    }
}
