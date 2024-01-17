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
     
        public static string ReturnProductValues(string productName = "", string productID = "", string productPrice = "0", string reference = "000" , int forId = 0)
        {
            Console.WriteLine("\n\n+===========================+\nproduto {0}",forId);
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

        public static string mainDatabase(string name, string price, string reference, int id = 1, bool isUsed = false)
        {
            string[] n = new string[999];
            string[] p = new string[999];
            string[] r = new string[999];
            string not = string.Format("não armazenado");
            name = n[id] ?? string.Empty;
            price = p[id] ?? string.Empty;
            reference = r[id] ?? string.Empty;
            string valueForReturn = string.Format(n[id], p[id], r[id]);
            if (isUsed == true)
            {
                return valueForReturn;
            }
            else
            {
                Console.WriteLine(not);
            }
            return string.Empty;
        }

        public static string searchProduct()
        {
            string productString = string.Empty;
            Console.WriteLine("\nInsira o produto para pesquisa: ");
            productString = Console.ReadLine();
            if (productString != string.Empty)
            {
                mainDatabase(productString);
                productString = string.Empty;
            }
            else
            {
                Console.WriteLine("\nInsira um valor: ");
            }
            return string.Empty;
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
            string pr = "";
            string prId = "";
            string prPrices = "";
            string prRef = "";
            int ArrayValue = 0;
            ShowMenu();
            Console.WriteLine(machineName+AtualTime+"\n"+mainLForFunction);
            Console.WriteLine("Opção: ");
            string option = Console.ReadLine();
            if (option.Equals("1"))
            {
                Console.WriteLine("\nQuantos produtos você quer cadastrar? \n");
                string numberofvariables = Console.ReadLine();
                int numberVariablesOf = int.Parse(numberofvariables);
                bool isUsed = false;
                for (int i = 1; i <= numberVariablesOf; i++)
                {
                    pr = product[i];
                    prId = IDs[i];
                    prPrices = prices[i];
                    prRef = references[i];
                    ReturnProductValues(pr, prId, prPrices, prRef, i);
                    mainDatabase(pr, prPrices, prRef, i , isUsed);
                }
                Console.WriteLine("\nProdutos cadastrados com sucesso!\n");
            }
            else if (option.Equals("2"))
            {

            }
        }
    }
}
