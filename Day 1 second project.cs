using System;

namespace content
{
 
   class DayOneProject2
    {
        static void Main(string[] args)
        {
            var project = new DayOneProject2();
            Console.WriteLine("Insert the first value: ");
            float x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert the second value: ");
            float y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert an option: ");
            String option = Console.ReadLine();

            if (option == "sum" || option == "Sum")
            {
                Console.WriteLine("The sum is: "+sum(x, y));
            }
            else if (option == "subtration" || option == "Subtration")
            {
                Console.WriteLine("The subtration is: "+subtration(x,y));
            }
            else if (option == "multiplication" || option == "Multiplication")
            {
                Console.WriteLine("The multiplication is: "+multiplication(x,y));
            }
            else if (option == "division" || option == "Division")
            {
                Console.WriteLine("The division is: " + division(x, y));
            }
        }

        static float division(float x, float y)
        {
            return x / y;
        }
        static float multiplication(float x, float y)
        {
            return x * y;
        }
        static float subtration(float x, float y)
        {
            return x - y;
        }
        static float sum(float n1 , float n2)
        {
            return n1 + n2;
        }
    }
}
