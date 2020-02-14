using System;
using System.IO;

namespace Document
{
    class start
    {
        public static string CreateDoc()
        {
            Console.WriteLine("----Document----\n");
            Console.Write("Enter the name of the Document: ");
            string fileName = Console.ReadLine();
            Console.Write("Type what is in the Document: ");
            string text = Console.ReadLine();
            return text;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            start.CreateDoc(); 
        }
    }
}

