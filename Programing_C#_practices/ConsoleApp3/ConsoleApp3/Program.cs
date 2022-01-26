using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Opcion;
            do
            {
                MostrarMenu();
                Opcion = PedirOpcion(3);
                if (Opcion == 1)
                {

                }
                else if (Opcion == 2)
                {

                }
                else if (Opcion == 3)
                {

                }
            }
            while (Opcion != 0);

        }
        static void Suma()
        {
            Console.Write("A sumar");
            int num1 = PedirNumero();
            int num2 = PedirNumero();
            int resultado = num1 + num2;
            Console.WriteLine("Resultado: " + resultado);
            Console.WriteLine("Pulsa cualquier tecla");
            Console.ReadKey();
            

        }
        static void Resta()
        {
            Console.Write("A restar");
            int num1 = PedirNumero();
            int num2 = PedirNumero();
            int resultado = num1 - num2;
            Console.WriteLine("Resultado: " + resultado);
            Console.WriteLine("Pulsa cualquier tecla");
            Console.ReadKey();

        }
        static void Multiplicacion()
        {
            Console.Write("A multiplicar");
            int num1 = PedirNumero();
            int num2 = PedirNumero();
            int resultado = num1 * num2;
            Console.WriteLine("Resultado: " + resultado);
            Console.WriteLine("Pulsa cualquier tecla");
            Console.ReadKey();



        }
        static void MostrarMenu()
        {

            Console.Clear();
            Console.WriteLine("1.-Suma");
            Console.WriteLine("2.-Resta");
            Console.WriteLine("3.-Multiplicacion");
            Console.WriteLine("0.-Salir");


        }


        static int PedirNumero()
        {
            int Numero;
            Console.WriteLine("introduce un numero");
            Numero = int.Parse(Console.ReadLine());
            return Numero;
        }
        static int PedirOpcion(int OpcionMaximo)
        {
            int Opcion;
            do
            {
                Console.Write("introduce una opcion: ");
                Opcion = int.Parse(Console.ReadLine());

            }
            while (Opcion < 0 || Opcion > OpcionMaximo);
            return Opcion;
        }
    }
}
