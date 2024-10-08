internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        //Nombrar variables //

        bool Jugar = true;
        while (Jugar)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the game'Adivina el numero'!");
            Console.Write("Ingrese el numero de jugadores (2-4): ");
            int numPlayers = int.Parse(Console.ReadLine());

            int RangoMax = numPlayers switch
            {
                2 => 50,
                3 => 100,
                4 => 200,
                _ => throw new ArgumentException("Numero de jugadotres no valido ")
            };
            Random random = new Random();
            int numeroSorpresa = random.Next(0, RangoMax + 1);

            bool AdivinoElNumero = false;
            int Turno = 0;
            while (!AdivinoElNumero)
            {
                Console.WriteLine($"\nTurno del jugador {Turno + 1}");
                Console.Write("Ingrese su número: ");
                int numeroIngresado = int.Parse(Console.ReadLine());

                if (numeroIngresado > numeroSorpresa)
                {
                    Console.WriteLine("MENOR");
                }
                else if (numeroIngresado < numeroSorpresa)
                {
                    Console.WriteLine("MAYOR");
                }
                else
                {
                    Console.WriteLine("¡Ganaste!");
                    AdivinoElNumero = true;
                }
                Turno = (Turno + 1) % numPlayers;
            }
            Console.Write("\n¿Deseas Jugar De Nuevo? (s/n): ");
            Jugar = Console.ReadLine().ToLower() == "s";
        }
    }
}
