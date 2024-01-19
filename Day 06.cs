using System;
using System.Security.Cryptography.X509Certificates;

namespace Class01
{
    public class index
    {
        public struct person
        {
            public string name;
            public int age;
            public int id;
        }

        public struct product
        {
            public string productname;
            public int reference;
            public float price;
        }

        public static void Main(string[] args)
        {
            person c;
            product p;
            Console.WriteLine("Insert the client name: ");
            c.name = Console.ReadLine();
            Console.WriteLine("\n+==========================+");
            Console.WriteLine("Insert the product name: ");
            p.productname = Console.ReadLine();
            string Clientproduct = string.Format("Client: '" + c.name + "' product: '" + p.productname+"'");
            Console.WriteLine(Clientproduct);
        }
    }
}
