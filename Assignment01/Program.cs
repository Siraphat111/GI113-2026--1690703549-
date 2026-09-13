/*
 * Student ID :1690703549
 * Name       :Siraphat Darasa
 * Section    :129B
 * No.        : NA
 * Course     : GI113 Computer Programming (GI)
 */
namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            const string GameName = "=== ▄︻╦芫≡══-- ⌯⁍ 𝑅𝑒𝑑 𝐷𝑒𝑎𝑑 𝑅𝑒𝑑𝑒𝑚𝑝𝑡𝑖𝑜𝑛 𝐼𝐼 ✞ ===";
            
            var mainCharacter = "Arthur Morgan 𐂂";
            var mainCharacterRole = "Outlaw";
            int mainCharacterAge = 36;
            char mainCharacterBloodType = 'O';      
            string mainCharacterGender = "Male";
            string mainCharacterNationality = "American";
            float mainCharacterHp = 100.6f;
            double mainCharacterMoney = 1000.5;
            bool mainCharacterIsAlive = true;

            Console.WriteLine($"=={GameName}==");
            Console.WriteLine($"Main Character : {mainCharacter}");
            Console.WriteLine($"Role : {mainCharacterRole}");
            Console.WriteLine($"AGE : {mainCharacterAge}");
            Console.WriteLine($"Blood Type : {mainCharacterBloodType}"); 
            Console.WriteLine($"Gender : {mainCharacterGender}");
            Console.WriteLine($"Nationality : {mainCharacterNationality}");
            Console.WriteLine($"Health : {mainCharacterHp}");
            Console.WriteLine($"Money : {mainCharacterMoney:C}");
            Console.WriteLine($"Is Alive : {mainCharacterIsAlive}");
           
            Console.WriteLine("-------------------");

            double mainCharacterAgeAsDouble = mainCharacterAge;
            Console.WriteLine($"Age as double (Implicit): {mainCharacterAgeAsDouble}");

            int mainCharacterHpTruncatedTo = (int)mainCharacterHp;
            int mainCharacterHpRounded = Convert.ToInt32(mainCharacterHp);
            Console.WriteLine($"Health (Truncated): {mainCharacterHpTruncatedTo}");
            Console.WriteLine($"Health (Rounded): {mainCharacterHpRounded}");
           
            Console.WriteLine("-------------------");
            
            Console.WriteLine("𝚁𝙳𝚁𝟸 𝙸𝚂 𝙰 𝙼𝙰𝚂𝚃𝙴𝚁𝙿𝙸𝙴𝙲𝙴.");
           
            Console.ReadLine();
        }
    }
}
