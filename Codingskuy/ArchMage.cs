using System;
using System.IO.Pipes;

namespace GameInteritanceDemo
{
    public class ArchMage : Mage
    {
        public int ancientKnowledge;

        public ArchMage()
        {
            Console.WriteLine("----> konstruktor default ArchMage <----");
        }

        public ArchMage(int ancientknowledge, int spellPower, string id, string name, int basePower, string address)
        : base(spellPower,id, name, basePower,address)
        {
             Console.WriteLine("----> konstruktor berparameter ArchMage <----");
             this.ancientKnowledge = ancientknowledge;
        }

        public new void DisplayData()
        {
            base.DisplayBaseData();
            Console.WriteLine("ANCIENT KNOWLEDGE        = "+ ancientKnowledge );
            Console.WriteLine("TOTAL POWER  = " + (GetBasePower() + spellPower + ancientKnowledge));
            Console.WriteLine("=======================");
        }
    }
}