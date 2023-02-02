using System;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {          
            Console.WriteLine("metin yaz");
            string text =Console.ReadLine();
            Console.WriteLine(ededleryerlesir(text));
        }
        static bool ededleryerlesir(string text)
        {
            foreach(char c in text)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
