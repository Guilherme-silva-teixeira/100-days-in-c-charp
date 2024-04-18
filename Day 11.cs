class program
{
    public static void Main(String[] args)
    {
        try
        {
            string[] array = new string[13];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("insert the value of the " + i + " array: ");
                array[i] = Console.ReadLine();
            }
            if (array.Length <= 0)
            {
                return;
            } else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == "0")
                    {
                        Console.WriteLine("\nThe value of the array is null\n");
                    }
                    else
                    {
                        Console.WriteLine(array[i]+"\n");
                    }
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }
    }
}
