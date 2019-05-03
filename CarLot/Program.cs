using System;
using System.Collections.Generic;

namespace CarLot
{
    class Program
    {
        static void Main(string[] args)
        {
            CarLot usedCars = new CarLot("Used Cars");
            Car mazda = new Car(//car attributes go here);
            Car bmw = new Car();
            Truck f150 = new Truck();
            usedCars.Add(mazda);
            usedCars.Add(bmw);
            usedCars.Add(f150);

            usedCars.PrintInventory();
        }
    }

    public class CarLot
    //represents a car lot
    {
        public string name;
        public List<Vehicle> inventory;

        public void Add(Vehicle vehicle) {
            //code goes here
        }

        public void PrintInventory() {
            //code goes here
        }
    }
    public abstract class Vehicle
    //parent class that has common attributes of cars and trucks
    {
        public string licensePlate;
        public string make;
        public string model;
        public double price;

        public string ToString() {
            //code goes here
            return s;
        }
    }
    public class Car : Vehicle
    //child class that extends vehicle
    {

    }
    public class Truck : Vehicle
    //child class that extends vehicle
    {

    }

}
