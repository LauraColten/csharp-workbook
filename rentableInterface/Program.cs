using System;
using System.Collections.Generic;

namespace rentableInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car();
            Car c2 = new Car();
            Boat b1 = new Boat();
            Boat b2 = new Boat();
            House h1 = new House();
            House h2 = new House();

            List<IRentable> rentables = new List<IRentable> ();
            rentables.Add(c1);
            rentables.Add(c2);
            rentables.Add(b1);
            rentables.Add(b2);
            rentables.Add(h1);
            rentables.Add(h2);

            c1.getDailyRate();
            c2.getDailyRate();

            for(int i = 0; i < rentables.Count; i++)
            {
                Console.WriteLine(rentables[i].getDescription());
                Console.WriteLine("Daily rental rate is: $" +rentables[i].getDailyRate());

            }

        }
    }

    public class Boat : IRentable
    {
        float hourlyRate = 100;
        public float getDailyRate()
        {
            return hourlyRate * 24;
        }
        public string getDescription()
        {
            return "I am a boat.";
        }
    }

    public class Car : IRentable
    {
        float dailyRate = 10;
        public float getDailyRate()
        {
            return dailyRate;
        }
        public string getDescription()
        {
            return "I am a car.";
        }
    }

    public class House : IRentable
    {
        float weeklyRate = 850;
        public float getDailyRate()
        {
            return weeklyRate / 7;
        }
        public string getDescription()
        {
            return "I am a house";
        }
    }
    public interface IRentable
    {
        float getDailyRate();

        string getDescription();
    }
}
