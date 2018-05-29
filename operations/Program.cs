using System;

namespace operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            bool isStudent = false;

            if (age <= 0)
                Console.WriteLine("Invalid age");
            else if (age >= 65)
                Console.WriteLine("pay $7");
            else if (age <= 12 && age > 0)
                Console.WriteLine("pay $8");
            else if (isStudent)
                Console.WriteLine("pay $8");
            else
                Console.WriteLine("pay $10");

        }
    }
}
