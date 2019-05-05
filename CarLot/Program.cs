using System;
using System.Collections.Generic;

namespace CarLot
{
    class Program
    {
        static void Main(string[] args)
        {
            CarLot usedCars = new CarLot("Used Cars");
            Car mazda = new Car("ABC123", "Mazda", "CX9", 27000, "SUV", 4);
            Car bmw = new Car("DEF456", "BMW", "X5", 65000, "SUV", 4);
            Truck f150 = new Truck("GHI789", "Ford", "F150", 35000, "Standard");
            usedCars.Add(mazda);
            usedCars.Add(bmw);
            usedCars.Add(f150);

            usedCars.PrintInventory();

            CarLot newCars = new CarLot("New Cars");
            Car tesla = new Car("JKL890", "Tesla", "Model X", 109000, "SUV", 4);
            Car honda = new Car("MNO098", "Honda", "Clarity", 38000, "Sedan", 4);
            Truck tundra = new Truck("PQR987", "Toyota", "Tundra", 46000, "Extended");
            newCars.Add(tesla);
            newCars.Add(honda);
            newCars.Add(tundra);

            newCars.PrintInventory();

        }
    }

    public class CarLot
    //represents a car lot
    {
        public string name;

        public CarLot(string initialName)
        {
            this.name = initialName;
        }
        public List<Vehicle> inventory = new List<Vehicle>();

        public void Add(Vehicle vehicle) {
            inventory.Add(vehicle);
        }

        public void PrintInventory() {
            for (int i = 0; i < inventory.Count; i++) {
                Console.WriteLine(inventory[i].ToString());

            }
        }
    }
    public abstract class Vehicle
    //parent class that has common attributes of cars and trucks
    {
        public string licensePlate;
        public string make;
        public string model;
        public double price;

         public Vehicle(string initialLicensePlate, string initialMake, string initalModel, double initialPrice)
        {
            this.licensePlate = initialLicensePlate;
            this.make = initialMake;
            this.model = initalModel;
            this.price = initialPrice;
        }


    }
    public class Car : Vehicle
    //child class that extends vehicle
    {

        public string type;
        public int numberDoors;

        public Car(string licensePlate, string make, string model, double price, string initialType, int initialNumberDoors) : base(licensePlate, make, model, price)
        {
            this.type = initialType;
            this.numberDoors = initialNumberDoors;
        }

         override public string ToString() {
            string s = string.Format("({0}), ({1}), ({2}), ({3}), ({4}), ({5})", this.make, this.model, this.licensePlate, this.price, this.type, this.numberDoors);
            return s;
         }
    }
    public class Truck : Vehicle
    //child class that extends vehicle
    {
        public string bedSize;
        public Truck(string licensePlate, string make, string model, double price, string initialBedSize) : base(licensePlate, make, model, price)
        {
            this.bedSize = initialBedSize;
        }

         override public string ToString() {
            string s = string.Format("({0}), ({1}), ({2}), ({3}), ({4})", this.make, this.model, this.licensePlate, this.price, this.bedSize);
            return s;
        }
    }
}

