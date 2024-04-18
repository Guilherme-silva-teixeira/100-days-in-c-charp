class program
{
    public static void Main(String[] args)
    {
        try
        {
            string[] array = new string[13];
            for (int i = 0; i < array.Length; i++)
            {
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
                        Console.WriteLine("The value of the array is null");
                    }
                    else
                    {
                        Console.WriteLine(array[i]);
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
