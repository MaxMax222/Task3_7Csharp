using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q42
{
    class Program
    {
        static void PrintSame(int[] arr)
        {
            Console.Write($"{arr[0]}");
            for (int i = 1; i < arr.Length; i++)
            {
                Console.Write($", {arr[i]}");
            }
            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
            int num;
            Console.Write("enter the length of the 1st array: ->");
            num = int.Parse(Console.ReadLine());
            int[] arr1 = new int[num];
            Console.Write("enter the length of the 2nd array: ->");
            num = int.Parse(Console.ReadLine());
            int[] arr2 = new int[num];
            Console.WriteLine("in the first array:");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write("enter a number: ->");
                arr1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("in the first array:");
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write("enter a number: ->");
                arr2[i] = int.Parse(Console.ReadLine());
            }

            HashSet<int> arr1Set = new HashSet<int>(arr1);
            HashSet<int> arr2Set = new HashSet<int>(arr2);
            int cntSame = 0;
            foreach (int number in arr1Set)
            {
                if (arr2Set.Contains(number))
                {
                    cntSame++;
                }
            }
            int[] arrSame = new int[cntSame];
            int index = 0;
            foreach  (int number in arr1Set)
            {
                if (arr2Set.Contains(number))
                {
                    arrSame[index] = number;
                    index++;
                }
            }
            //PrintSame(arrSame);
            Console.WriteLine($"the same numbers in both arrays: {string.Join(",", arrSame)}");
        }
    }
}
