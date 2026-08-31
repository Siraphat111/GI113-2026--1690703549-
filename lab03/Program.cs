/*
 * Student ID :1690703549
 * Name       :Siraphat Darasa
 * Section    :129B
 * No.        :na
 * Course     : GI113 Computer Programming (GI)
 */

namespace lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MaxLevel = 10;

            var bossName = "Kirin";   // ต้องประกาศด้วย var ห้ามเขียน string ตรงๆ
            var rank = 'S';            // ต้องประกาศด้วย var ห้ามเขียน char ตรงๆ
            int level = 7;
            int maxHp = 240;
            int currentHp = 115;       // ค่าตั้งต้นของ Lab นี้คือ HP "หลังโดนโจมตี" จาก Lab 2 แล้ว ไม่ใช่ 175
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            //BOSS STATUS
            Console.WriteLine("== KIRIN SAVE CONVERTER ==");
            Console.WriteLine($"NAME: {bossName}" +
                   $"\nRANK: {rank}" +
                   $"\nLEVEL: {level} / {MaxLevel}" +
                   $"\nMAX HP: {maxHp}" +
                   $"\nATTACK POWER: {attackPower}" +
                   $"\nCRIT MULTIPLIER: {critMultiplier}" +
                   $"\nIS BOSS: {isBoss}");

            //Implicit Conversion HP (int) --> double
            Console.WriteLine("\n----- Implicit Conversion: HP as double -----");
            double currenHPDouble = currentHp;
            Console.WriteLine($"HP (double): {currenHPDouble}");

            //Calculate Percen as double
            Console.WriteLine("\n----- Calculate HP Percentage -----");
            Double hpPercentExact = currenHPDouble * 100 / maxHp;
            Console.WriteLine($"Hp Percent (exact): {hpPercentExact}");

            //Explicit Casting attack power (float) --> int
            Console.WriteLine("\n----- Explicit Casting: Attack Power -> Display int -----");
            float attackPowerFloat = attackPower; int attackDisplay = (int)attackPowerFloat;
            Console.WriteLine($"Attack Power (int cast): {attackDisplay}");

            //cast vs. convert: Crit Multiplier
            Console.WriteLine("\n----- Cast vs. Convert: Crit Multiplier -----");
            int critMultiplierInt = (int)critMultiplier; 
            int critConvert = Convert.ToInt32(critMultiplier);
            Console.WriteLine($"Crit Multiplier (int cast): {critMultiplierInt}");
            Console.WriteLine($"Crit Multiplier (convert rounded): {critConvert}");

        }

    }
}