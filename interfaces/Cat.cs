using System;
namespace Mammal
{
    class Cat: Mammal
    {
        public void speak()
        {
            Console.WriteLine("Meow!");
        }

        public void run()
        {
            Console.WriteLine("Cats can run at a top speed of 30 mph!");
        }
        public void eat()
        {
            Console.WriteLine("Cats eat mice");
        }
    }

}