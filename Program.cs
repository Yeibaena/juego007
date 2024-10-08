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
            int


                {

                }
            }
        }
    }
}