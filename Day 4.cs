//this program verify your machine
using System;
using System.IO;

namespace project4
{
    public class project4
    {
        private static void WriteInfo(string ContentInfo)
        {
            string Uptime = string.Format("{0}", DateTime.Now.ToString("dd-MM-yyyy - HH-mm-ss"));
            string filename = string.Format("PCSpecs - result [{0}].txt", Uptime);

            using (StreamWriter wf = File.CreateText(filename))
            {
                wf.WriteLine(ContentInfo);
            }

            Console.WriteLine(string.Format("Arquivo escrito em: {0}\\{1}", Environment.CurrentDirectory, filename));
        }

        public static void ShowInfo(bool write)
        {
            string Is64bit;

            if(Environment.Is64BitOperatingSystem == true)
            {
                Is64bit = "Sim";
            }
            else
            {
                Is64bit = "Não";
            }

            string result = string.Format(
                "informações do PC:\r\r" +
                "==================\r\n\r\n" +

                "Sistema:\r\n" +
                "---------\r\n" +
                "Nome da máquina: {0}\r\n" +
                "Versão do sistema: {1}\r\n" +
                "64-bit: {2}\r\n" +
                "Processadores: {3}\r\n" +
                "Versão CLR: {4}\r\n\r\n"+

                "Local: \r\n"+
                "-------\r\n"+
                "Usuário atual: {5}\r\n"+
                "Comando de execução: {7}\r\n",

                Environment.MachineName,
                Environment.OSVersion,
                Is64bit,
                Environment.ProcessorCount,
                Environment.Version,
                Environment.UserName,
                Environment.CurrentDirectory,
                Environment.CommandLine
                );
            Console.WriteLine(result);
            if(write == true)
            {
                WriteInfo(result);
            }
        }

        public static void Main(string[] args)
        {
            string version = "1.0";
            bool createFile = false;
            if (args.Length == 1)
            {
                if (args[0].Equals("-f") || args[0].Equals("--file"))
                {
                    createFile = true;
                }
            }
            ShowInfo(createFile);
        }
    }
}
