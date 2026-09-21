namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int live = 5;

            if (live == 0)
            {
                Console.WriteLine("Game Over");
            }
            else
            {
                Console.WriteLine("Continue to play!");
            }


            Console.WriteLine("Continue to run");

            int level = 7;

            if (level >= 10)
            {
                Console.WriteLine("The door opens.");
            }
            else if (level >= 5)
            {
                Console.WriteLine("Boss floor unlocked.");
            }
            else
            {
                Console.WriteLine("The door stays shut.");
            }
        }
    }
}
