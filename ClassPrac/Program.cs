using System;
using System.Collections.Generic;

namespace ClassPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            Car redCar = new Car("redCar", 50);
            Car blueCar = new Car("blueCar", 70);

            Person person1 = new Person("Zoe", 650);
            Person person2 = new Person("Artie", 77);

            List<IRace> racers = new List<IRace>();
            racers.Add(redCar);
            racers.Add(blueCar);
            racers.Add(person1);
            racers.Add(person2);

            foreach(IRace racer1 in racers)
            {
                foreach(IRace racer2 in racers)
                {
                    IRace winner = race(racer1, racer2);
                    Console.WriteLine("{0} vs {1} = {2}", racer1, racer2, winner.getCelebrateMessage());
                }
            }


        }

        public static IRace race(IRace racer1, IRace racer2)
            {
                if (racer1.getSpeedMPH() > racer2.getSpeedMPH())
                {
                    return racer1;
                }else
                {
                    return racer2;
                }
            }
    }

    public interface IRace
    {
        double getSpeedMPH();
        string getCelebrateMessage();
    }

    public class Car : IRace
    {
        public string name;
        public double speed;

        public Car(string initialName, double initialSpeed)
        {
            this.name = initialName;
            this.speed = initialSpeed;
        }

        override public string ToString()
        {
            string s = string.Format("{0}, ({1})", this.name, this.speed);
            return s;
        }

        public double getSpeedMPH()
        {
            return this.speed;
        }

        public string getCelebrateMessage()
        {
            return "Great driving!";
        }


    }

    public class Person : IRace
    {
        public string humanName {get; private set;}
        public double humanSpeed {get; private set;}
        public Person(string initialHumanName, double initialHumanSpeed)
        {
            this.humanName = initialHumanName;
            this.humanSpeed = initialHumanSpeed;
        }

        override public string ToString()
        {
            return this.humanName;
        }

        public double getSpeedMPH()
        {
            return this.humanSpeed * 60 / 1609.34;
        }

        public string getCelebrateMessage()
        {
            return string.Format("My name is {0}, and I am the greatest", this.humanName);
        }

    }

}
