using System;
using System.IO;

namespace program
{
    class project5
    {
        public static void ShowMenu()
        {
            string mainL = string.Format("============================");
            string mainlf = string.Format("+");
            string fullbar = mainlf + mainL + mainlf;
            string breakL = string.Format("\n");
            string verticalBar = string.Format("||");
            string lineN1 = string.Format(" Menu: ");
            string lineN2 = string.Format(" 01 - Cadastrar produto:");
            string lineN3 = string.Format(" 02 - Pesquisar produto:");
            string lineN4 = string.Format(" 03 - Mostrar produto:");
            string lineN5 = string.Format(" 04 - Pesquisar produto:");
            string mainLineN1 = verticalBar + lineN1 + breakL;
            string mainLineN2 = verticalBar + lineN2 + breakL;
            string mainLineN3 = verticalBar + lineN3 + breakL;
            string mainLineN4 = verticalBar + lineN4 + breakL;
            string mainLineN5 = verticalBar + lineN5 + breakL;

            Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}", fullbar, breakL, mainLineN1, mainLineN2, mainLineN3, mainLineN4, mainLineN5, fullbar);
        }
     
        public static string ReturnProductValues()
        {
            string productName = "";
            string productID = "";
            string productPrice = string.Format("0");
            string reference = string.Format("000");

            Console.WriteLine("\nInsira o nome do produto: \n");
            productName = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("\nInsira o id do produto: \n");
            productID = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("\nInsira o preço do produto: \n");
            productPrice = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("\nInsira a refrerência do produto: \n");
            reference = Console.ReadLine() ?? string.Empty;

            return productName + productID + productPrice + reference;
        }

        public static void Main(string[] args)
        {
            string mainLForFunction = string.Format("+============================+");
            string machineName = string.Format("executado em: {0}\n", Environment.MachineName);
            string AtualTime = string.Format("Em : {0} "+"as {1} UTC", DateTime.Now.ToString("dd-MM-yy HH-mm-ss"), DateTime.UtcNow.ToString("HH-mm-ss"));
            string[] CreateArray = new string[999];
            string[] product = new string[999];
            string[] references = new string[999];
            string[] prices = new string[999];
            string[] IDs = new string[999];
            int ArrayValue = 0;
            ShowMenu();
            Console.WriteLine(machineName+AtualTime+"\n"+mainLForFunction);
            Console.WriteLine("Opção: ");
            int option = Console.Read();
            switch (option)
            {
                case 1:
                    Console.WriteLine("\nQuantos produtos você quer cadastrar? \n");
                    break;

                case 2:

                    break;

                case 3:

                    break;

                case 4:

                    break;

                case 5:

                    break;

                default:
                    Console.WriteLine("\nOpção inválida");
                    break;
            }
        }
    }
}
