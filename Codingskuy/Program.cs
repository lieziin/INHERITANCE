using System;
namespace GameInteritanceDemo
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("=== DEMO INHERITANCE ===\n");

            Console.WriteLine("1. Membuat objek Warrior (dengan konstruktor berparameter)");
            ClassWarrior warrior = new ClassWarrior(50, "W-001", "Arthas", 100, "Stromwind");
            warrior.DisplayData();

            Console.WriteLine("\n2. Membuat objek Mage (dengan konsturktor berparameter)");
            Mage mage = new Mage(80, "M-001", "Jaina", 90, "dalaran");
            mage.DisplayBaseData();

            Console.WriteLine("\n3. Membuat objek ArchMage (dengan konsturktor berparameter)");
           ArchMage archmage = new ArchMage(120, 80, "AM-001", "khadgar", 110, "Karazhan");
            archmage.DisplayBaseData();

            Console.ReadKey();
        }
    }
}