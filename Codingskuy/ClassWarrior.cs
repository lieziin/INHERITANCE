namespace GameInteritanceDemo
{
    public class ClassWarrior : Character
    {
        
        public int bonus;


        public ClassWarrior()
        {
            Console.WriteLine("----> konstruktor default Warrior <----");
        }

        public ClassWarrior(int bonus, string id, string name,int basePower, string address)
        : base(id, name, basePower,address)
        {
             Console.WriteLine("----> konstruktor berparameter Warrior <----");
             this.bonus = bonus;
        }

        public void DisplayData()
        {
            base.DisplayBaseData();
            Console.WriteLine("BONUS        = " + bonus);
            Console.WriteLine("TOTAL POWER  = " + (GetBasePower() + bonus));
            Console.WriteLine("=======================");
        }
    }
}