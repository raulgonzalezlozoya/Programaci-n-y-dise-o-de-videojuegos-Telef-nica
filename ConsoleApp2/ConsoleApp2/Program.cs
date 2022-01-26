using System;

using System.Collections.Generic;
using System.Text;

namespace PiramideAsteriscos
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.Write("introduce un número :");
            
            
                int filas = int.Parse(Console.ReadLine());
                if (filas != 0)
                {

                    int a;
                    int espacios;
                    for (int i = 1; i <= filas; i++)
                    {
                        StringBuilder final = new StringBuilder();

                        espacios = filas - i;
                        a = i + (i - 1);
                        for (int n = 0; n < espacios; n++)
                            final.Append(" ");

                        for (int i2 = 0; i2 < a; i2++)
                            final.Append("*");

                        Console.WriteLine(final.ToString());

                    }
                }  
        }
    }
}