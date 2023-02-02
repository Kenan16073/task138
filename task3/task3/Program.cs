using System;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {              
                Console.WriteLine("metin yaz");
                string text = Console.ReadLine();
                Console.WriteLine(wordcount2(text));
            }
        }
        static int wordcount(string text)
        {
            int wordCount = 0;
            bool wordstarted=false;
            foreach(char c in text)
                if (char.IsWhiteSpace(c))
                {
                    wordstarted = false;
                }
                else if (!wordstarted)
                {
                    wordstarted = true;
                    wordCount++;
                }
            return wordCount;
        }
        static int wordcount2(string text)
        {
            string[] words = text.Split(' ');
            int wordCount = words.Length;

            return wordCount;
        }
    }
}
