using System;
using System.Collections.Generic;

namespace OOP1
{
  class Program
  {
    static void Main(string[] args)
    {

      List<Person> people = new List<Person>();
      for (int i = 0; i < 3; i++)
      {

        Person x = new Person();
        Console.WriteLine("Enter your first name: ");
        x.firstName = Console.ReadLine();
        Console.WriteLine("Enter your last name: ");
        x.lastName = Console.ReadLine();
        Console.WriteLine("Enter your DOB: ");
        x.dOb = Console.ReadLine();
        people.Add(x);
      }

      for (int i = 0; i < people.Count; i++)
      {
        Person w = people[i];
        string FullName = Person.StaticFullName(w.firstName, w.lastName);
        Console.WriteLine("Full Name: {0}", FullName); ;
        Console.WriteLine("DOB: {0}", w.dOb);
      }
    }

    Person p0 = people[0];
    string FullName0 = p0.NonStaticFullName();
  }


  class Person
  {
    public string firstName;
    public string lastName;
    public string dOb;

    public static string StaticFullName(string f, string l)
    {
      string full = f + " " + l;
      return full;
    }

    public string NonStaticFullName() {
        return this.firstName+" "+this.lastName;
    }

  }

}
