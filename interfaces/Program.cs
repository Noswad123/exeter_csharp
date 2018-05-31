using System;
using Mammal;

namespace interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog rex = new Dog();
            Cow betsy = new Cow();
            Cat felix = new Cat();
            rex.speak();
            rex.run();
            betsy.speak();
            betsy.run();
            felix.speak();
            felix.run();
        }
    }
}
