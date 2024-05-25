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

    }
