using System;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 3, 4, 7876, 42, 455 };
            addvaluetoarr(ref num, 5555);
            foreach (int i in num)
            {
                Console.WriteLine(i);
            }
        }
        static void addvaluetoarr(ref int[] arr, int value)
        {
            int[] newarr = new int[arr.Length + 1];
            Array.Copy(arr, newarr, arr.Length);
            newarr[newarr.Length - 1] = value;
            arr = newarr;

        }

    }
}
