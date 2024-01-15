using System;

namespace project3
{
    public class project3
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("insert the value of the first cateto: ");
            float co = Console.Read();
            Console.WriteLine("insert the value of the second cateto: ");
            float ca = Console.Read();
            //Console.WriteLine("insert the value of the hypotenuse: ");
            //float h = Console.Read();
            float res = ((co * co) + (ca * ca));
            double value = Math.Sqrt(res);
            Console.WriteLine("the value is: " + value);
        }
    }
}
