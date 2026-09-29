using System;

namespace GameInteritanceDemo
{
    public class Character
    {
        
        private string? characterID;
        private string? name;
        private int basePower;
        private string? address;


        public Character()
        {
            Console.WriteLine("----> konstruktor default Character <----");
        }

        public Character(string id, string name, int basePower, string address)
        {
            Console.WriteLine("----> konstruktor berparameter Character <----");
            this.characterID = id;
            this.name = name;
            this.basePower = basePower;
            this.address = address;
        }

        public void DisplayBaseData()
        {
            Console.WriteLine("Character ID  =" + characterID);
            Console.WriteLine("NAME  =" + name);
            Console.WriteLine("BASE POWER  =" + basePower);
            Console.WriteLine("ADDRESS  =" + address);
        }

        public int  GetBasePower()
        {
            return basePower;
        }
    }
}