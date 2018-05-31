using System;
namespace Mammal
{
    class Dog : Mammal
    {
        public void speak()
        {
            Console.WriteLine("Bark!");
        }

        public void run()
        {
            Console.WriteLine("Dogs can run at a top speed of 45 mph!");
        }

        public void eat()
        {
            Console.WriteLine("Dogs eat bones");
        }
    }
}