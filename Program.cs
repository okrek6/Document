using System;
using System.IO;

namespace Document
{
    class Document
    {
        public static string CreateDoc(string fileName, string text)
        {
            try
            {
                StreamWriter streamWriter = new StreamWriter(fileName + ".txt");
                streamWriter.WriteLine(text);
                streamWriter.Close();
                string success = ($"{fileName} was saved. The doc has {text.Length} characters in it.");
                return success;
            }
            catch (Exception e) //this passes in a variable e of type Exception to be used in the scope
            {
                string fail = ("Exception: " + e.Message);
                return fail;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Document----\n");
            Console.Write("Enter the name of the Document: ");
            string fileName = Console.ReadLine();
            Console.Write("Type what is in the Document: ");
            string text = Console.ReadLine();
            string result = Document.CreateDoc(fileName, text);
            Console.WriteLine(result); 
        }
    }
}

