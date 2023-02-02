using System;
using System.Diagnostics;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string cumle = "   salam qardaw   ";
            deletethespace(ref cumle);
            Console.WriteLine(cumle);


            int number = -56432187;
            changenum(ref number);
            Console.WriteLine(number);
        }
        //Verilmis yazinin icindeki butun bosluqlari silen metod
        static void deletethespace(ref string str)
        {
            string newstr = " ";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                    newstr += str[i];
            }
            str = newstr;
        }
        //Verilmis ededi menfidirse musbet musbetdirse menfi ededn metod
        static void changenum(ref int number)
        {
            number *= -1;
        }
    }
}
