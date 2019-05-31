using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace entityPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            Person kevin = new Person();
            kevin.dad = null;
            kevin.mom = null;
            kevin.name = "Kevin";
            kevin.gender = Gender.Male;
            Person laura = new Person();
            laura.dad = null;
            laura.mom = null;
            laura.name = "Laura";
            laura.gender = Gender.Female;
            Person eden = new Person();
            eden.dad = kevin;
            eden.mom = laura;
            eden.name = "Eden";
            eden.gender = Gender.Female;
            Person eve = new Person();
            eve.mom = laura;
            eve.dad = kevin;
            eve.name = "Eve";
            eve.gender = Gender.Female;
            Person arlo = new Person();
            arlo.dad = kevin;
            arlo.mom = laura;
            arlo.name = "Arlo";
            arlo.gender = Gender.Male;

            Console.WriteLine(eden);
            Console.WriteLine(eden.dad);
            Console.WriteLine(eden.mom);

            PersonContext context = new PersonContext();
            context.Database.EnsureCreated();
            context.persons.Add(kevin);
            context.SaveChanges();
            context.persons.Add(laura);
            context.SaveChanges();
            context.persons.Add(eden);
            context.SaveChanges();
            context.persons.Add(eve);
            context.SaveChanges();
            context.persons.Add(arlo);
            context.SaveChanges();






        }
    }

    public class Person
    {
        public int id { get; private set; }
        public string name { get; set;}
        public int momId { get; set;}
        public virtual Person mom { get; set; }
        public int dadId { get; set; }
        public virtual Person dad { get; set; }

        public List<Person> siblings;
        public Gender gender;

        public Person ()
        {

        }

        override public string ToString()
        {
            return string.Format("{0}", this.name);
        }

    }

    public enum Gender
    {
        Female = 1,
        Male = 2
    }

    public class PersonContext : DbContext
    {
      public DbSet<Person> persons {get; private set;}
      override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        optionsBuilder.UseSqlite("Filename=./family.db");
      }
    }
}
