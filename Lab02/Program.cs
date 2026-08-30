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

            Console.WriteLine("==== HUNTER STATUS: AFTER DAMAGE ====");
            Console.WriteLine($"HP: {currentHp}/{maxHp}");
            hpPercentage = currentHp * 100 / maxHp;
            Console.WriteLine($"hpPercentage: {hpPercentage}%");
           
            string hunter = "Rin";
            char hunterRank = 'B';
            int FameHunter = 7;
            int maxHphunter = 100;
            int currentHphunter = 50;
            float attackPowerhunter = 10.5f;
            double critMultiplierhunter = 1.75;
            bool isHunter = true;
            Console.WriteLine($"Hunter: {hunter}");
            Console.WriteLine($"Rank: {hunterRank}");
            Console.WriteLine($"Fame: {FameHunter}");
            Console.WriteLine($"Max HP: {maxHphunter}");
            Console.WriteLine($"Current HP: {currentHphunter}");
            Console.WriteLine($"Attack Power: {attackPowerhunter}");
            Console.WriteLine($"Critical Multiplier: {critMultiplierhunter}");
            Console.WriteLine($"Is Hunter: {isHunter}");

            Console.WriteLine("==== KNIGHT STATUS: AFTER DAMAGE ====");
            Console.WriteLine($"HP: {currentHp}/{maxHp}");
            hpPercentage = currentHp * 100 / maxHp;
            Console.WriteLine($"hpPercentage: {hpPercentage}%");
           
            string knight = "Shaka";
            char knightRank = 'S';
            int FameKnight = 100;
            int maxHpknight = 1000;
            int currentHpknight = 800;
            float attackPowerknight = 200.5f;
            double critMultiplierknight = 1.75;
            bool isKnight = true;
            Console.WriteLine($"Knight: {knight}");
            Console.WriteLine($"Rank: {knightRank}");
            Console.WriteLine($"Fame: {FameKnight}");
            Console.WriteLine($"Max HP: {maxHpknight}");
            Console.WriteLine($"Current HP: {currentHpknight}");
            Console.WriteLine($"Attack Power: {attackPowerknight}");
            Console.WriteLine($"Critical Multiplier: {critMultiplierknight}");
            Console.WriteLine($"Is Knight: {isKnight}");

            Console.WriteLine("==== KING STATUS: AFTER DAMAGE ====");
            Console.WriteLine($"HP: {currentHp}/{maxHp}");
            hpPercentage = currentHp * 100 / maxHp;
            Console.WriteLine($"hpPercentage: {hpPercentage}%");

            string king = "Arthur";
            char kingRank = '0';
            int FameKing = 10000;
            int maxHpking = 1500;
            int currentHpking = 1000;
            float attackPowerking = 50.5f;
            double critMultiplierking = 1.75;
            bool isKing = true;
            Console.WriteLine($"King: {king}");
            Console.WriteLine($"Rank: {kingRank}");
            Console.WriteLine($"Fame: {FameKing}");
            Console.WriteLine($"Max HP: {maxHpking}");
            Console.WriteLine($"Current HP: {currentHpking}");
            Console.WriteLine($"Attack Power: {attackPowerking}");
            Console.WriteLine($"Critical Multiplier: {critMultiplierking}");
            Console.WriteLine($"Is King: {isKing}");

            Console.WriteLine("==== MAGE STATUS: AFTER DAMAGE ====");
            Console.WriteLine($"HP: {currentHp}/{maxHp}");
            hpPercentage = currentHp * 100 / maxHp;
            Console.WriteLine($"hpPercentage: {hpPercentage}%");

            string mage = "Merlin";
            char mageRank = '?';
            int FameMage = 100000000;
            int maxHpmage = 150000;
            int currentHpmage =14500;
            float attackPowermage = 500.5f;
            double critMultipliermage = 1.75;
            bool isMage = true;
            Console.WriteLine($"Mage: {mage}");
            Console.WriteLine($"Rank: {mageRank}");
            Console.WriteLine($"Fame: {FameMage}");
            Console.WriteLine($"Max HP: {maxHpmage}");
            Console.WriteLine($"Current HP: {currentHpmage}");
            Console.WriteLine($"Attack Power: {attackPowermage}");
            Console.WriteLine($"Critical Multiplier: {critMultipliermage}");
            Console.WriteLine($"Is Mage: {isMage}");  
        }
    }
}
