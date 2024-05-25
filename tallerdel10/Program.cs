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

            }
