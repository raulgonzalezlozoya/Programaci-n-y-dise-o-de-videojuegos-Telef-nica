using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string texto;
            //int numero;
            ulong G;
            int i;
            ulong D;
            
            ulong F;
            Console.WriteLine("Quiero 1 grano de trigo por la primera casilla...");
            
            for (i = 0; i <64; i++) 
            {
                
                D = (ulong)Math.Pow(2, i);
                G = (ulong)Math.Pow(2,i-1);
                F = D + G;



                Console.Write("Numero de granos en casilla " );
                Console.Write(i+1+" :");
                Console.WriteLine(D);
                if (i==63)
                {
                    Console.WriteLine("numero total de granos: " + F);
                }
                
            }

            

           
            //texto = Console.ReadLine();
            //numero = int.Parse(texto);            
        }
    }
}
