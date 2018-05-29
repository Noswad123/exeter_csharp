using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person me = new Person("Jamal", "Dawson");

            Console.WriteLine(me.firstName + " " + me.lastName);
        }
    }
    public class Person
    {
        public string firstName;
        public string lastName;
        public int age;
        public Person()
        {
            firstName = "";
            lastName = "";
            age = 0;
        }
        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            if (age < 0)
            {
                this.age = 0;
            }
            else
            {
                this.age = age;
            }

        }
    }
}
