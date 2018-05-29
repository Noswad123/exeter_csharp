using System;

namespace arraysAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[] names = { "Jamal", "Jared", "Funmi", "Tim" };

            foreach (string name in names)
            {
                Console.WriteLine($"Where is {name} today?");
            }

            for (int i = names.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"Where is {names[i]} today?");
            }
        }
    }
}
