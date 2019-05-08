using System;

namespace HumanClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Human h1 = new Human("John", "Jack");
            SuperHuman s1 = new SuperHuman("Superman", "Clark Kent", "speed");
            Console.WriteLine(h1.getGreeting());
            Console.WriteLine(s1.getGreeting());


        }
    }

    class Human
    {
        public string name;
        public string nickname;

        public Human(string initialName, string initialNickname)
        {
            this.name = initialName;
            this.nickname = initialNickname;

        }

        public virtual string getGreeting() {return "Hi, my name is " +name+ ", but you can call me: " +nickname;}

    }

    class SuperHuman : Human
    {
        public string superPower;

        public SuperHuman(string name, string nickname, string initialSuperPower) : base(name, nickname)
        {
            this.superPower = initialSuperPower;
        }

        public override string getGreeting() { return "Hi, my name is " +name+ ", my nickname is " +nickname+ ", and my super power is: " +superPower;}

    }
}
