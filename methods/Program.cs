using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            doubleMe(5);
        }
        public static int doubleMe(int myInt)
        {
            Console.WriteLine($"Before: {myInt}");
            int dummy = myInt * 2;
            Console.WriteLine($"After: {dummy}");
            return dummy;
        }
        public static int quadrupleMe(int myInt)
        {
            int dummy = doubleMe(myInt);
            dummy = doubleMe(dummy);
            return dummy;
        }
        public static int doubleNumberTimes(int myInt, int times)
        {
            int dummy = myInt;
            for (int i = 0; i < times; i++)
            {
                dummy = doubleMe(dummy);
            }
            return dummy;
        }
    }
}
