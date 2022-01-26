using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ejercicio 1
            Console.WriteLine("Escribe un numero.");
            string texto = Console.ReadLine();
            int numero = int.Parse(texto);
            if (numero >= 0)
            {
                Console.WriteLine("El numero es positivo.");
            }
            else
            {
                Console.WriteLine("El numero es negativo.");
            } */


            /*Ejercicio 2
            Console.WriteLine("Escribe un numero.");
            string texto = Console.ReadLine();
            int numero = int.Parse(texto);
            if (numero >= 100)
            {
                Console.WriteLine("El numero es mayor que 100.");
            } else
            {
                Console.WriteLine("El numero no es mayor que 100.");
            }*/

            /*Ejercicio 3
            Console.WriteLine("Escribe un numero.");
            string texto = Console.ReadLine();
            int numero = int.Parse(texto);
            if (numero > 0 && numero < 100)
            {
                Console.WriteLine("El agua está en estado líquido.");
            }
            else
            {
                Console.WriteLine("El agua no está en estado líquido.");
            }*/

            /*Ejercicio 4
            Console.WriteLine("Escribe un numero.");
            string texto = Console.ReadLine();
            int numero = int.Parse(texto);
            Console.WriteLine("El numero multiplicado por 2 es " + numero*2);*/

            /*Ejercicio 5
            Console.WriteLine("Escribe un numero.");
            string texto = Console.ReadLine();
            int numero = int.Parse(texto);
            if (numero%2 == 0)
            {
                Console.WriteLine("El numero es par.");
            }
            else
            {
                Console.WriteLine("El numero es impar.");
            }*/

            /* Ejercicio 6
            Console.WriteLine("Escribe un numero.");
            string texto = Console.ReadLine();
            int numero = int.Parse(texto);
            if(numero == 1)
            {
                Console.WriteLine("El dia correspondiente es Lunes. ");
            } else if (numero == 2)
            {
                Console.WriteLine("El dia correspondiente es Martes. ");
            }else if (numero == 3)
            {
                Console.WriteLine("El dia correspondiente es Miercoles. ");
            } else if (numero == 4)
            {
                Console.WriteLine("El dia correspondiente es Jueves. ");
            } else if (numero == 5)
            {
                Console.WriteLine("El dia correspondiente es Viernes. ");
            } else if (numero == 6)
            {
                Console.WriteLine("El dia correspondiente es Sabado. ");
            } else if (numero == 7)
            {
                Console.WriteLine("El dia correspondiente es Domingo. ");
            } else
            {
                Console.WriteLine("No hay dia correspondiente a ese numero.");
            }*/

            /*Ejercicio 7
            Console.WriteLine("Escribe un numero.");
            string texto = Console.ReadLine();
            int numero = int.Parse(texto);
            if (numero == 1 || numero == 3 || numero == 5 || numero == 7 || numero == 8 || numero == 10 || numero == 12)
                {
                    Console.WriteLine("El mes " + numero + " tiene 31 dias.");
                } else if (numero == 4 || numero == 6 || numero == 9 || numero == 11)
                {
                    Console.WriteLine("El mes " + numero2 + " tiene 30 dias.");
                } else if (numero == 2)
                {
                    Console.WriteLine("El mes de febrero tiene 29 dias.");
                } else
                {
                    Console.WriteLine("El numero indicado no es un mes.");
                }*/

            /* Ejercicio 8
            Console.WriteLine("Escribe un numero.");
            string texto = Console.ReadLine();
            int numero = int.Parse(texto);
            Console.WriteLine("Escribe otro numero.");
            string texto2 = Console.ReadLine();
            int numero2 = int.Parse(texto2);
            if (numero > numero2)
            {
                Console.WriteLine("El numero " + numero + " es mayor.");
            } else if (numero < numero2)
            {
                Console.WriteLine("El numero " + numero2 + " es mayor.");
            } else
            {
                Console.WriteLine("Los numeros " + numero + " y " + numero2 + " son iguales.");
            }*/

            /* Ejercicio 9
            Console.WriteLine("Vamos a ordenar 3 numeros de menor a mayor.\nEscribe un numero.");
            string texto = Console.ReadLine();
            int numero = int.Parse(texto);
            Console.WriteLine("Escribe otro numero.");
            string texto2 = Console.ReadLine();
            int numero2 = int.Parse(texto2);
            Console.WriteLine("Escribe otro numero.");
            string texto3 = Console.ReadLine();
            int numero3 = int.Parse(texto3);
            if (numero < numero2 && numero2 < numero3)
            {
                Console.WriteLine(numero + "<" + numero2 + "<" + numero3);
            } else if (numero < numero3 && numero3 < numero2)
            {
                Console.WriteLine(numero + "<" + numero3 + "<" + numero2);
            } else if (numero2 < numero && numero < numero3)
            {
                Console.WriteLine(numero2 + "<" + numero + "<" + numero3);
            } else if (numero2 < numero3 && numero3 < numero)
            {
                Console.WriteLine(numero2 + "<" + numero3 + "<" + numero);
            } else if (numero3 < numero && numero < numero2)
            {
                Console.WriteLine(numero3 + "<" + numero + "<" + numero2);
            } else if (numero3 < numero2 && numero2 < numero)
            {
                Console.WriteLine(numero3 + "<" + numero2 + "<" + numero);
            } else if (numero ==  numero2 && numero2 < numero3)
            {
                Console.WriteLine(numero + "=" + numero2 + "<" + numero3);
            } else if(numero == numero3 && numero3 < numero2)
            {
                Console.WriteLine(numero + "=" + numero3 + "<" + numero2);
            } else if (numero2 == numero3 && numero3 < numero)
            {
                Console.WriteLine(numero2 + "=" + numero3 + "<" + numero);
            } else
            {
                Console.WriteLine(numero + "=" + numero2 + "=" + numero3);
            }*/
            // EL 10 ES IGUAL QUE EL ANTERIOR PERO CAMBIANDO LOS SIGNOS.

            /*Ejercicio 11
            Console.WriteLine("Escribe una letra.");
            string texto = Console.ReadLine();
            if (texto == "a" || texto == "e" || texto == "i" || texto == "o" || texto == "u")
            {
                Console.WriteLine("La letra es vocal.");
            }
            else
                Console.WriteLine("La letra es consonante o un numero/simbolo.");
        }*/
            /*Ejercicio 12
                Console.WriteLine("Vamos a sumar dos numeros.\nIntroduzca el primer numero:");
                string texto = Console.ReadLine();
                int numero = int.Parse(texto);
                Console.WriteLine("Introduzca el segundo numero:");
                string texto2 = Console.ReadLine();
                int numero2 = int.Parse(texto2);
                Console.WriteLine("La suma de " + numero + " y " + numero2 + " es " + (numero + numero2));
            }*/
            /*Ejercicio 13
            Console.WriteLine("Vamos a hacer el cuadrado de un numero.\nIntroduzca el numero:");
            string texto = Console.ReadLine();
            int numero = int.Parse(texto);
            Console.WriteLine("El cuadrado del numero " + numero + " es " + (numero * numero));
        }*/

            /*Ejercicio 14
            int numero;
            string texto;
            while (true)
            {
                Console.WriteLine("Escribe un numero. Escribe 0 para que el programa acabe.");
                texto = Console.ReadLine();
                numero = int.Parse(texto);
                if (numero == 0)
                {
                    break;
                }
            } */

            /* Ejercicio 15
            int numero;
            string texto;
            while (true)
            {
                Console.WriteLine("Escribe un numero. Escribe 0 para que el programa acabe.");
                texto = Console.ReadLine();
                numero = int.Parse(texto);
                if (numero != 0)
                {
                    Console.WriteLine("El cuadrado del numero " + numero + " es : " + (numero * numero));
                }

                if (numero == 0)
                {
                    break;
                }
            }*/

            /* Ejercicio 16
            string texto;
            int numero;
            int suma = 0;
            while (true)
            {
                Console.WriteLine("Escribe un numero. Escribe 0 para que el programa acabe.");
                texto = Console.ReadLine();
                numero = int.Parse(texto);
                suma = suma + numero;
                if (numero == 0)
                {
                    Console.WriteLine("La suma de todos los numeros introducidos es : " + suma);
                    break;
                }
            }*/

            /* Ejercicio 17
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
            }*/

            /* Ejercicio 18
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("El cuadrado de " + i + " es " + (i * i));
            }*/

            /* Ejercicio 19
            Console.WriteLine("Escriba un numero.");
            string texto = Console.ReadLine();
            int numero = int.Parse(texto);
            for (int i = 0; i <= numero; i++)
            {
                Console.WriteLine(i);
            }*/

            /*Ejercicio 20
            Console.WriteLine("Escriba un numero.");
            string texto = Console.ReadLine();
            int numero = int.Parse(texto);
            for (int i = 0; i <= numero; i+=2)
            {
                Console.WriteLine(i);
            }*/

            /* Ejercicio 21
            string texto;
            int numero;
            while (true)
            {
                Console.WriteLine("Escriba un numero.\nEscriba 0 para acabar el programa.");
                texto = Console.ReadLine();
                numero = int.Parse(texto);
                if ((numero % 7) == 0 && numero != 0)
                {
                    Console.WriteLine("El numero es divisible entre 7.");
                }
                else if ((numero % 7 != 0))
                {
                    Console.WriteLine("El numero no es divisible entre 7.");
                } else if(numero == 0)
                {
                    break;
                }
            }*/

            /* Ejercicio 22
            string texto, texto2;
            int numero, numero2;
            Console.WriteLine("Escribe un numero.");
            texto = Console.ReadLine();
            numero = int.Parse(texto);
            Console.WriteLine("Escribe otro numero.");
            texto2 = Console.ReadLine();
            numero2 = int.Parse(texto2);
            Console.WriteLine("El resto de dividir " + numero + " entre " + numero2 + " es " + (numero%numero2));
        */

            /* Ejercicio 23
            string texto, texto2;
            int numero, numero2;
            Console.WriteLine("Escribe un numero.");
            texto = Console.ReadLine();
            numero = int.Parse(texto);
            Console.WriteLine("Escribe otro numero.");
            texto2 = Console.ReadLine();
            numero2 = int.Parse(texto2);
            if ((numero % numero2) == 0)
            {
                Console.WriteLine("El numero " + numero + " es divisible entre " + numero2);
            }
            else
            {
                Console.WriteLine("Los numeros " + numero + " y " + numero2 + " no son divisibles entre ellos.");
            }*/

            /* Ejercicio 24
            string texto;
            int numero, lista = 0;
            Console.WriteLine("Escriba un numero.");
            texto = Console.ReadLine();
            numero = int.Parse(texto);
            for (int i = 1; i < (numero + 1); i++)
            {
                if ((numero % i) == 0)
                {
                    lista++;
                } 
            } 

            if (lista != 2)
            {
                Console.WriteLine("El numero " + numero + " no es primo.");
            } else
            {
                Console.WriteLine("El numero " + numero + " es primo.");
            }*/

            /* Ejercicio 25
            Console.WriteLine("Escriba un año.");
            string texto = Console.ReadLine();
            int numero = int.Parse(texto);
            if ((numero % 4) == 0)
            {
                Console.WriteLine("El año " + numero + " es bisiesto.");
            }
            else
            {
                Console.WriteLine("El año " + numero + " no es bisiesto.");
            }*/

            /* Ejercicio 26
                  Console.WriteLine("Escriba un año.");
                  string texto = Console.ReadLine();
                  int numero = int.Parse(texto);
                  Console.WriteLine("Escriba un numero de mes.");
                  string texto2 = Console.ReadLine();
                  int numero2 = int.Parse(texto2);
                  if ((numero % 4) == 0)
                  {
                      Console.WriteLine("El año " + numero + " es bisiesto.");
                      if (numero2 == 1 || numero2 == 3 || numero2 == 5 || numero2 == 7 || numero2 == 8 || numero2 == 10 || numero2 == 12)
                      {
                          Console.WriteLine("El mes " + numero2 + " tiene 31 dias.");
                      } else if (numero2 == 4 || numero2 == 6 || numero2 == 9 || numero2 == 11)
                      {
                          Console.WriteLine("El mes " + numero2 + " tiene 30 dias.");
                      } else if (numero2 == 2)
                      {
                          Console.WriteLine("El mes de febrero tiene 29 dias.");
                      } else
                      {
                          Console.WriteLine("El numero indicado no es un mes.");
                      }
                  }
                  else
                  {
                      Console.WriteLine("El año " + numero + " no es bisiesto.");
                      if (numero2 == 1 || numero2 == 3 || numero2 == 5 || numero2 == 7 || numero2 == 8 || numero2 == 10 || numero2 == 12)
                      {
                          Console.WriteLine("El mes " + numero2 + " tiene 31 dias.");
                      }
                      else if (numero2 == 4 || numero2 == 6 || numero2 == 9 || numero2 == 11)
                      {
                          Console.WriteLine("El mes " + numero2 + " tiene 30 dias.");
                      }
                      else if (numero2 == 2)
                      {
                          Console.WriteLine("El mes de febrero tiene 28 dias.");
                      }
                      else
                      {
                          Console.WriteLine("El numero indicado no es un mes.");
                      }
                  }*/

            /* Ejercicio 27
                
            while (true)
            {
                Console.WriteLine("Escriba la hora.");
                string texto = Console.ReadLine();
                int hora = int.Parse(texto);
                Console.WriteLine("Escriba los minutos.");
                string texto2 = Console.ReadLine();
                int minutos = int.Parse(texto2);
                if (hora >= 01 && hora <= 24)
                {
                    if (minutos >=00 && minutos <= 60)
                    {
                        Console.WriteLine("La hora es " + hora + ":" + minutos);
                        break;
                    } 
                }
            }*/

            /* Ejercicio 28
            while (true)
            {
                Console.WriteLine("Escriba la hora.");
                string texto = Console.ReadLine();
                int hora = int.Parse(texto);
                Console.WriteLine("Escriba los minutos.");
                string texto2 = Console.ReadLine();
                int minutos = int.Parse(texto2);
                if (hora >= 01 && hora <= 24)
                {
                    if (minutos >= 00 && minutos < 60)
                    {
                        Console.WriteLine("La hora es " + hora + ":" + minutos);
                        if (minutos >= 00 && minutos < 45)
                        {
                            Console.WriteLine("La hora quince minutos despues es " + hora + ":" + (minutos + 15));
                        }
                        else if (minutos >= 45 && minutos <= 54 && hora != 24)
                        {
                            hora = hora + 1;
                            minutos = minutos - 45;
                            Console.WriteLine("La hora quince minutos despues es " + hora + ":0" + minutos);
                        }
                        else if (minutos >= 55 && minutos < 60 && hora != 24)
                        {
                            hora = hora + 1;
                            minutos = minutos - 45;
                            Console.WriteLine("La hora quince minutos despues es " + hora + ":" + minutos);
                        }
                        else if (minutos >= 45 && minutos <= 54 && hora == 24)
                        {
                            hora = 1;
                            minutos = minutos - 45;
                            Console.WriteLine("La hora quince minutos despues es " + hora + ":0" + minutos);
                        }

                        else if (minutos >= 55 && minutos < 60 && hora == 24)
                        {
                            hora = 1;
                            minutos = minutos - 45;
                            Console.WriteLine("La hora quince minutos despues es " + hora + ":" + minutos);
                        }
                    }
                }
            }*/

            /* Ejercicio 29
            double resultado, numero = 2;
            Console.WriteLine("Las 15 primeras potencias de 2 son:");
            for (int i = 0; i <= 15; i++)
            {
                resultado = Math.Pow(numero, i);
                Console.WriteLine(resultado);
            }*/

            /* Ejercicio 30
            double resultado, numero = 2, suma = 0;
            for (int i = 0; i <= 64; i++)
            {
                resultado = Math.Pow(numero, i);
                suma = suma + resultado; 
                Console.WriteLine(resultado);
            }
            Console.WriteLine("La suma es : " + suma);
        */
        }
    }
}
