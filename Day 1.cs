using System;

namespace Day_one
{
    class dayOne
    {
        static void Main(String[] args)
        {
            First();
            Second();
            Third();
        }

        static void First()
        {
            Console.WriteLine("Hello, World");
        }

        //variables
        static int Second()
        {
            int n1 = 2;
            int n2 = 3;
            int res = n1 + n2;
            Console.WriteLine(res);
            return 1;
        }

        static void Third()
        {
            String name = Console.ReadLine();
            Console.WriteLine(name);
        }
    }
}
