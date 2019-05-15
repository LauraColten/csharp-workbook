using System;

namespace classPractice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Address a1 = new Address("Westslope Cir", "45th St", "Austin", "Texas", 78731);
            DriversLicense d1 = new DriversLicense("Laura", "Colten", a1, 'F', 'C');
            Console.WriteLine(a1);
            Console.WriteLine(d1);
            Person person = new Person("Arlo", "Colten", GenderType.Female);
        }
    }

    public class Address
    {
        public string street1;
        public string street2;

        public string city;
        public string state;
        public int zip;

        public Address(string initialStreet1, string initialStreet2, string initialCity, string initialState, int initialZip )
        {
            this.street1 = initialStreet1;
            this.street2 = initialStreet2;
            this.city = initialCity;
            this.state = initialState;
            this.zip = initialZip;
        }


        override public string ToString()
        {
            string s = string.Format("{0} {1} {2} {3} {4}",  this.street1, this.street2, this.city, this.state, this.zip);
            return s;
        }


    }

    public class DriversLicense
    {
        public string firstName;
        public string lastName;
        public  Address address;
        public char gender;
        public char licenseType;

        public DriversLicense(string initialFirstName, string initialLastName, Address initialAddress, char initialGender, char initialLicenseType)
        {
            this.firstName = initialFirstName;
            this.lastName = initialLastName;
            this.address = initialAddress;
            this.gender = initialGender;
            this.licenseType = initialLicenseType;
        }

         override public string ToString()
        {
            string s = string.Format("{0} {1} {2} {3} {4}",  this.firstName, this.lastName, this.address, this.gender, this.licenseType);
            return s;
        }
    }

    struct Person
    {
        public string firstName;
        public string lastName;

        public GenderType gender;
        public Person(string s1, string s2, GenderType s3)
        {
            this.firstName = s1;
            this.lastName = s2;
            this.gender = s3;
        }

        public string getFullName()
        {
            return firstName+""+lastName;
        }
    }

    enum DaysOfTheWeek
    {
        Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
    }

    enum GenderType
    {
        Female, Male, Other
    }

}
