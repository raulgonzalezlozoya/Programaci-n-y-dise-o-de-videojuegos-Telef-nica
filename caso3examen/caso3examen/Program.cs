using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caso3examen
{
    class Program
    {
        static void Main(string[] args)
        {

            // crear el array
            int[] listaNumeros = new int[5];
            int multiplicador;

            // rellenar el array con números introducidos por el usuario
            for (int i = 0; i < listaNumeros.Length; i++)
            {
                Console.Write("Introduce un numero a multiplicar: ");
                listaNumeros[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Introduce el numero que multiplica: ");
            multiplicador = int.Parse( Console.ReadLine());
            
            
            Console.WriteLine("Los resultados son: ");
            for (int i = 0; i < listaNumeros.Length; i++)
            {
                listaNumeros[i] = listaNumeros[i] * multiplicador;
                Console.WriteLine(listaNumeros[i]);
              
            }
        }


    }
    
}
