public class Progran
{
    static void Main(string[] args)
    {
        int N = 5; // Tamaño del tablero NxN
        int[,] tablero = new int[N, N];
        int filaActual = 0;
        int columnaActual = 0;
        int puntaje = 0;

        InicializarTablero(tablero, N);
        MostrarTablero(tablero, filaActual, columnaActual, puntaje);

        while (true)
        {
            ConsoleKeyInfo tecla = Console.ReadKey(true);

            switch (tecla.Key)
            {
                case ConsoleKey.W:
                case ConsoleKey.UpArrow:
                    if (filaActual > 0)
                    {
                        puntaje += tablero[filaActual - 1, columnaActual];
                        tablero[filaActual, columnaActual] = tablero[filaActual - 1, columnaActual];
                        tablero[--filaActual, columnaActual] = 0;
                    }
                    break;
                case ConsoleKey.A:
                case ConsoleKey.LeftArrow:
                    if (columnaActual > 0)
                    {
                        puntaje += tablero[filaActual, columnaActual - 1];
                        tablero[filaActual, columnaActual] = tablero[filaActual, columnaActual - 1];
                        tablero[filaActual, --columnaActual] = 0;
                    }
                    break;
                case ConsoleKey.S:
                case ConsoleKey.DownArrow:
                    if (filaActual < N - 1)
                    {
                        puntaje += tablero[filaActual + 1, columnaActual];
                        tablero[filaActual, columnaActual] = tablero[filaActual + 1, columnaActual];
                        tablero[++filaActual, columnaActual] = 0;
                    }
                    break;
                    break;
                case ConsoleKey.S:
                    break;
                case ConsoleKey.DownArrow:
                    if (filaActual < N - 1)
                    {
                        puntaje += tablero[filaActual + 1, columnaActual];
                        tablero[filaActual, columnaActual] = tablero[filaActual + 1, columnaActual];
                        tablero[++filaActual, columnaActual] = 0;
                    }
                    break;

                    MostrarTablero(tablero, filaActual, columnaActual, puntaje);
            }
        }

        static void InicializarTablero(int[,] tablero, int N)
        {
            Random rand = new Random();

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    tablero[i, j] = rand.Next(1, 10);
                }
            }

            tablero[0, 0] = 0; // Posición inicial
        }

        static void MostrarTablero(int[,] tablero, int filaActual, int columnaActual, int puntaje)
        {
            Console.Clear();

            int N = tablero.GetLength(0);

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (i == filaActual && j == columnaActual)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("0 ");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(tablero[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("Puntaje: " + puntaje);
            Console.WriteLine("Menú de opciones:");
            Console.WriteLine("W - Mover Arriba");
            Console.WriteLine("A - Mover Izquierda");
            Console.WriteLine("S - Mover Abajo");
            Console.WriteLine("D - Mover Derecha");
            Console.WriteLine("Esc - Salir del Juego");

        }
    }
}