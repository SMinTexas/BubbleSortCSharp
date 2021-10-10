using System;

namespace BubbleSortCSharp
{
    public class BubbleSort
    {
        static void Main(string[] args)
        {
            int[] arr = { 78, 55, 35, 97, 15, 97, -13, 105, -126, 1001, 6, 0, 10, 19, 84 };
            int temp;
            Console.WriteLine("Original Array:");
            foreach (int item in arr)
            {
                Console.Write(" " + item);
            }
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Sorted Array: ");
            foreach(int item in arr)
            {
                Console.Write(" " + item);
            }
            Console.ReadLine();
        }
    }
}
