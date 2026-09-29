using System;

namespace GameInteritanceDemo
{
    public class Mage : Character
    {
        public int spellPower;

        public Mage()
        {
            Console.WriteLine("----> konstruktor default Mage <----");
        }

        public Mage(int spellPower, string id, string name, int basePower, string address)
        : base(id, name, basePower,address)
        {
             Console.WriteLine("----> konstruktor berparameter Mage <----");
             this.spellPower = spellPower;
        }

        public void DisplayData()
        {
            base.DisplayBaseData();
            Console.WriteLine("SPELL POWER        = " + spellPower);
            Console.WriteLine("TOTAL POWER  = " +  + spellPower);
            Console.WriteLine("=======================");
        }
    }
}