using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraydesplazar
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] listaNumeros = new int[5];
            while(true)
            {
                //pedir numero
                Console.WriteLine("introduce un  numero: ");
                int N = int.Parse(Console.ReadLine());
                //introducir numero y desplazar el resto


                listaNumeros[4] = listaNumeros[3];
                listaNumeros[3] = listaNumeros[2];
                listaNumeros[2] = listaNumeros[1];
                listaNumeros[1] = listaNumeros[0];
                listaNumeros[0] = N;


                //mostrar contenido
                for (int i=0;i<5;i++)
                {



                    Console.Write(listaNumeros[i] + " ");

                }
                Console.Write("\n");
            }


        }
    }
}
