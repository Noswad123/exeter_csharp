using System;
namespace Mammal
{
    class Cow : Mammal
    {
        public void speak()
        {
            Console.WriteLine("Moo!");
        }

        public void run()
        {
            Console.WriteLine("Cows can run at a top speed of 25 mph!");
        }
        public void eat()
        {
            Console.WriteLine("Cows eat grass");
        }
    }

}