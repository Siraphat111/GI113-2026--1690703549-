/*
 * Student ID :1690703549
 * Name       :Siraphat Darasa
 * Section    :129B
 * No.        : NA
 * Course     : GI113 Computer Programming (GI)
 */

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "Kaiser";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("==== BOSS STATUS: INITIAL ====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");    
            Console.WriteLine($"Max HP: {maxHp}");
            Console.WriteLine($"Current HP: {currentHp}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Critical Multiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");
            
            int hpPercentage = currentHp * 100 / maxHp;
            Console.WriteLine($"hpPercentage: {hpPercentage}%");
            Console.WriteLine();
            
            Console.WriteLine($"kaiser take 60 damage!");
            currentHp = currentHp - 60;
            Console.WriteLine();

            Console.WriteLine("==== BOSS STATUS: AFTER DAMAGE ====");
            Console.WriteLine($"HP: {currentHp}/{maxHp}");
            hpPercentage = currentHp * 100 / maxHp;
            Console.WriteLine($"hpPercentage: {hpPercentage}%");


        }
    }
}
