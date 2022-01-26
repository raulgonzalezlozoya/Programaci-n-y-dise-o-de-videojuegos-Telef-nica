using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SpaceInvaders2017
{
    class Program
    {
        struct AtribEnemigos
        {
            public string simbolo;
            public char s;
            public ConsoleColor color;
            public bool visible;
            public int posColInicial;
            public int posFilaInicial;
            public int x, y;
            public float incrX;
            public float incrY;
        }
        static int numDisparos, numEnemigos;
        static AtribEnemigos[] disparos;
        static AtribEnemigos[] enemigos;
        static bool juegoTerminado;
        static bool partidaTerminada;
        int origWidth, width;
        int origHeight, height;
        static ConsoleKeyInfo tecla;
        static int nombre;
        static AtribEnemigos Texto;
        static AtribEnemigos Em2;
        static AtribEnemigos personaje;
        // static AtribEnemigos disparo;
        static int Enemigos;
        AtribEnemigos[] caracterE = new AtribEnemigos[Enemigos];
        static Random generador;
        static string[] naves = { "###############" };
        static char bala = '*';
        static int vidas, puntos;

        static int cXb;
        static int cYb;
        static int incYb = -1;

        public static void Presentacion()
        {
            Console.Clear();
            Console.SetCursorPosition(33, 20);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("--------------Seleccione una opción-------------\t");
            Console.SetCursorPosition(50, 24);
            Console.Write("[1] Iniciar\t");
            Console.SetCursorPosition(50, 26);
            Console.Write("[0] Salir\t");
            Texto.posColInicial = 30;
            Texto.posFilaInicial = 7;
            Texto.x = Texto.posColInicial;
            Texto.y = Texto.posFilaInicial;

            Console.SetCursorPosition((int)Texto.x, (int)Texto.y);

            Texto.simbolo = "Hola";
            //Texto.simbolo = Properties.Resources.SpaceInvadersTitle;
            //Texto.simbolo = "Hola";
            Texto.color = ConsoleColor.Red;
            Console.ForegroundColor = Texto.color;
            Console.WriteLine(Texto.simbolo);

            Em2.posColInicial = 39;
            Em2.posFilaInicial = 11;
            Em2.x = Em2.posColInicial;
            Em2.y = Em2.posFilaInicial;
            Console.SetCursorPosition((int)Em2.x, (int)Em2.y);
            Em2.simbolo = "Hola";
            //Em2.simbolo = Properties.Resources.muestra1;
            //Em2.simbolo = "Hola";
            Em2.color = ConsoleColor.White;
            Console.ForegroundColor = Em2.color;
            Console.WriteLine(Em2.simbolo);

            tecla = Console.ReadKey(true);
            if (tecla.KeyChar == '0')
            {
                partidaTerminada = true; juegoTerminado = true;

            }

        }
        public static void IniciarJuego()
        {
            juegoTerminado = false;
            numDisparos = 18;

            disparos = new AtribEnemigos[numDisparos];
            generador = new Random();
        }

        public static void InicializarPartida()
        {
            partidaTerminada = false;
            vidas = 3;
            puntos = 0;
            personaje.posColInicial = 60;
            personaje.posFilaInicial = 28;

            personaje.x = personaje.posColInicial;
            personaje.y = personaje.posFilaInicial;


            personaje.color = ConsoleColor.Yellow;

            personaje.s = 'A';



            /*   for (int i = 0; i < numEnemigos; i++)
               {
                   enemigos[i].x = generador.Next(25, 80);
                   enemigos[i].y = generador.Next(2, 2);
                   enemigos[i].incrX = 0.5f;
                   enemigos[i].incrY = 0.01f;
                   enemigos[i].s = 'x';
                   enemigos[i].color = ConsoleColor.Red;
               }
   */


        }
        public static void Dibujar()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("Vidas: {0}   -   Puntos: {1}", vidas, puntos);
            Console.SetCursorPosition((int)personaje.x, (int)personaje.y);
            Console.ForegroundColor = personaje.color;
            Console.WriteLine(personaje.s);

        }

        public static void ComprobarTeclas()
        {

            // Dibujar();

            if (Console.KeyAvailable)

            {
                tecla = Console.ReadKey(false);
                if ((tecla.Key == ConsoleKey.RightArrow) && (personaje.x < 99))
                {
                    personaje.x += 2;

                }
                if ((tecla.Key == ConsoleKey.LeftArrow) && (personaje.x > 14))
                {
                    personaje.x -= 2;

                }

                if ((tecla.Key == ConsoleKey.A))
                {

                    cYb = personaje.y;
                    cXb = personaje.x;
                    //dibujarBala();

                }



            }
        }
        public static void MoverDisparos()
        {

            if (cYb > 1)
            {
                cYb = cYb + incYb;
                dibujarBala();
            }


        }

        public static void dibujarBala()
        {
            Console.SetCursorPosition(cXb, cYb);
            Console.WriteLine(bala);
            MoverDisparos();
        }

        public static void MoverEnemigos()
        {
        }
        public static void DibujaEnemigos()
        {
            Console.SetCursorPosition(60, 5);
            foreach (string filaenemigos in naves)
            {
                Console.WriteLine(filaenemigos);
                Console.ForegroundColor = ConsoleColor.Blue;
            }
        }
        public static void DibujaScore()
        {

        }
        public static void PausaFotograma()
        {
            Thread.Sleep(40);
        }

        static void Main(string[] args)
        {
            IniciarJuego();
            while (!juegoTerminado)
            {

                InicializarPartida();
                Presentacion();
                while (!partidaTerminada)
                {
                    Dibujar();
                    ComprobarTeclas();
                    dibujarBala();
                    DibujaEnemigos();
                    PausaFotograma();
                }

            }



        }
    }
}