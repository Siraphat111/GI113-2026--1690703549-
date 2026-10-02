/*
* Student ID :1690703549
* Name       :Siraphat Darasa
* Section    :129B
* No.        : NA
* Course     : GI113 Computer Programming (GI)
*/
using System.ComponentModel.Design;

namespace Assignment02
{
    internal class Program
    { 
            const string MaterialName = "Copper";
            const double SmeltRate = 0.40;
            const double SalvageRate = 0.50;
            const double MaxBatch = 500;
            static void Main(string[] args)
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("---          Minecraft Ingot          ---");
                Console.WriteLine("-----------------------------------------");

                Console.WriteLine($"==> {MaterialName} Smelting {SmeltRate} / Salvage {SalvageRate}");
                Console.WriteLine("==> key 'S' for smelt (Ore -> copperIngot)");
                Console.WriteLine("==> key 'B' for Breakdown (copperIngot -> Ore)");

                Console.Write(" ==> Choose Menu:");
                bool menuConfirm = char.TryParse(Console.ReadLine(), out char menu);

                Console.Write("==> How much");
                bool amounConfirm = double.TryParse(Console.ReadLine(), out double amount);

                if (menuConfirm && amount > 0 && amount <= MaxBatch)
                {
                    if (menuConfirm && (menu == 'S' || menu == 's'))
                    {
                        double copperIngot = amount * SmeltRate;
                        Console.WriteLine($"==> {amount:F2} {MaterialName} copperOre == {copperIngot:F2} {MaterialName} copperIngot");
                    }
                    else if (menuConfirm && (menu == 'B' || menu == 'b'))
                    {
                        double copperOre = amount / SalvageRate;
                        Console.WriteLine($"==> {amount:F2} {MaterialName} copperIngot = {copperOre:F2} {MaterialName} copperOre");
                    }
                    else
                    {
                        Console.WriteLine("===> Error: Invalid menu. Please type S or B only.");
                    }
                }
                else
                {
                    Console.WriteLine($"===> Error: Invalid amount. Please type a number between 0 and {MaxBatch}.");
                }
            
        }
    }
}
