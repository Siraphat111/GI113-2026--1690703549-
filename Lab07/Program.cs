/*
 * Student ID :1690703549
 * Name       :Siraphat Darasa
 * Section    :129B
 * No.        : 34
 * Course     : GI113 Computer Programming (GI)
 */
namespace Lab07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Battle Command Menu (Hero vs Slime)");

            const int MonsterHp = 10;

            Console.Write("Monster Defense: ");
            int.TryParse(Console.ReadLine(), out int monsterDefense);
            Console.WriteLine($"A Slime appears! HP {MonsterHp}, DEF {monsterDefense}");
           
            Console.WriteLine("=== BATTLE MENU ===");
            Console.WriteLine("1) Attack");
            Console.WriteLine("2) Fire Magic");
            Console.WriteLine("3) Defend");
            Console.WriteLine("4) Run");
            Console.WriteLine("5) Ice Spear");
            Console.Write("Choose (1-5): ");
            int.TryParse(Console.ReadLine(), out int command);

            switch (command)
            {
                case 1:
                    Console.WriteLine("Hero swings the sword");
                    break;
                case 2:
                    Console.WriteLine("Hero casts Wild blade");
                    break;
                case 3:
                    Console.WriteLine("Hero raises the shield");
                    break;
                case 4:
                    Console.WriteLine("Hero looks for a way out");
                    break;
                case 5:
                    Console.WriteLine("Hero hurls an Ice Spear");
                    break;
                default:
                    Console.WriteLine("Hero hesitates. Invalid command");
                    break;
            }
            
            int power = command switch
            {
                1 => 12,
                2 => 18,
                5 => 15,
                _ => 0
            };
            int damage = Math.Max(0, power - monsterDefense);
            Console.WriteLine($"Damage: {damage}");

            string monsterStatus = damage >= MonsterHp ? "DEFEATED" : "still standing";
            Console.WriteLine($"Slime: {monsterStatus}");

            Console.Write("Really run away? (y/n): ");
            string answer = Console.ReadLine();

            switch (answer)
            {
                case "y":
                case "Y":
                    Console.WriteLine("You escaped!");
                    break;
                case "n":
                case "N":
                    Console.WriteLine("You stay and fight.");
                    break;
                default:
                    Console.WriteLine("Please type y or n.");
                    break;
            }
        }
    }
}
