// using System;
// using System.Collections.Generic;

// namespace CarGarage
// {
//   class Program
//   {
//     public static void Main()
//     {
//       Car blueCar = new Car("blue");
//       Garage smallGarage = new Garage(2);

//       smallGarage.ParkCar(blueCar, 0);

//       List<Person> people = new List<Person>();
//       for (int i = 0; i < 3; i++)
//       {
//         Console.WriteLine("Enter your name: ");
//         string name = Console.ReadLine();
//         Person x = new Person(name);
//         people.Add(x);
//       }
//       blueCar.People = people;
//       Console.WriteLine(smallGarage.Cars);
//     }
//   }

//   class Car
//   {
//     public Car(string initialColor)
//     {
//       Color = initialColor;
//     }

//     public List<Person> People = new List<Person>();


//     public string Color { get; private set; }

//   }

//   class Garage
//   {
//     private Car[] cars;

//     public Garage(int initialSize)
//     {
//       Size = initialSize;
//       this.cars = new Car[initialSize];
//     }

//     public int Size { get; private set; }

//     public void ParkCar(Car car, int spot)
//     {
//       cars[spot] = car;
//     }

//     public string Cars
//     {
//       get
//       {
//         for (int i = 0; i < cars.Length; i++)
//         {
//           if (cars[i] != null)
//           {
//             Console.WriteLine(String.Format("The {0} car is in spot {1}.", cars[i].Color, i));
//             Console.WriteLine("The people in the car are: ");
//             for (int j = 0; j < cars[i].People.Count; j++) {
//                 Console.Write(cars[i].People[j].Name+ " ");

//             }
//           }
//         }
//         return " ";
//       }
//     }
//   }

//   class Person
//   {
//     public Person(string firstName)
//     {
//       Name = firstName;
//     }
//     public string Name {get; set;}
//   }

// }
// represent a car as a car class
//represent a parking garage as a class
// use our parking garage class to manage our inventory

using System;
using System.Collections.Generic;

namespace CarGarage
{
  class Program {
    public static void Main()
    {
      Car c1 = new Car("black", "VW", "Jetta");
      Console.WriteLine("C1 = {0}", c1.toString());

      Car c2 = new Car("blue", "Volvo", "XC90");
      Console.WriteLine("C2 = {0}", c2.toString());

      ParkingGarage p1 = new ParkingGarage(7);
      for(int i = 0; i < p1.numSpaces; i++) {
        if (p1.isSpaceAvailable(i)) {
          p1.parkCar(c1, i);
          break;
        }
      }
      Console.WriteLine("Is space 1 empty? {0}", p1.isSpaceAvailable(5));

      p1.parkCar(c1, 1); //pass in the car you are parking and the space to park it in
      Console.WriteLine("Is space 1 empty? {0}", p1.isSpaceAvailable(1));

      p1.towCar(1);
      Console.WriteLine("Is space 1 empty? {0}", p1.isSpaceAvailable(1));

    }
   class Car
  {
    public string make {get; private set;}
    public string model{get; private set;}
    public string color;
    public string plateNumber;
    public int year;

    public Car(string initialColor, string initialMake, string initialModel)
    {
      this.color = initialColor;
      this.make = initialMake;
      this.model = initialModel;
    }

    public string toString()
    {
      string stringRepresentation = string.Format("{0} {1} {2}", this.color, this.make, this.model);
      return stringRepresentation;
    }
  }

   class ParkingGarage
   {
     public int numSpaces {get; private set;}
    private Car[] parkingSpaces;

    public ParkingGarage(int desiredNumberofSpaces)
    {
      parkingSpaces = new Car[desiredNumberofSpaces];
      numSpaces = desiredNumberofSpaces;
    }
    //this method should return true if the space is available, otherwise return false
    public bool isSpaceAvailable(int spaceNumber)
    {
      Car CarInTheSpace = parkingSpaces[spaceNumber];
      if (CarInTheSpace == null) {
        return true;
      }else {
        return false;
      }
    }

    public void parkCar(Car theCar, int theSpace)
    {
      bool isSpaceEmpty = isSpaceAvailable(theSpace);
      if(isSpaceEmpty == true) {
        this.parkingSpaces[theSpace] = theCar;
      }else{
        throw new Exception("Space " +theSpace+ " is taken!");
      }
    }

    public Car towCar(int theSpace)
    {
      Car CarInTheSpace = parkingSpaces[theSpace];
      parkingSpaces[theSpace] = null;
      return CarInTheSpace;
    }
   }
  }
}



