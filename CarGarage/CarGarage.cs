using System;
using System.Collections.Generic;

namespace CarGarage
{
  class Program
  {
    public static void Main()
    {
      Car blueCar = new Car("blue");
      Garage smallGarage = new Garage(2);

      smallGarage.ParkCar(blueCar, 0);

      List<Person> people = new List<Person>();
      for (int i = 0; i < 3; i++)
      {
        Console.WriteLine("Enter your name: ");
        string name = Console.ReadLine();
        Person x = new Person(name);
        people.Add(x);
      }
      blueCar.People = people;
      Console.WriteLine(smallGarage.Cars);
    }
  }

  class Car
  {
    public Car(string initialColor)
    {
      Color = initialColor;
    }

    public List<Person> People = new List<Person>();


    public string Color { get; private set; }

  }

  class Garage
  {
    private Car[] cars;

    public Garage(int initialSize)
    {
      Size = initialSize;
      this.cars = new Car[initialSize];
    }

    public int Size { get; private set; }

    public void ParkCar(Car car, int spot)
    {
      cars[spot] = car;
    }

    public string Cars
    {
      get
      {
        for (int i = 0; i < cars.Length; i++)
        {
          if (cars[i] != null)
          {
            Console.WriteLine(String.Format("The {0} car is in spot {1}.", cars[i].Color, i));
            Console.WriteLine("The people in the car are: ");
            for (int j = 0; j < cars[i].People.Count; j++) {
                Console.Write(cars[i].People[j].Name+ " ");

            }
          }
        }
        return " ";
      }
    }
  }

  class Person
  {
    public Person(string firstName)
    {
      Name = firstName;
    }
    public string Name {get; set;}
  }

}



