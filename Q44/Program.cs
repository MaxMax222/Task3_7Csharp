using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q44
{
    class Program
    {
        static void PrintArr(int[] arr)
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
            Console.Write("how many flowers u planted: ->");
            num = int.Parse(Console.ReadLine());
            int[] flower1 = new int[num];
            int[] flower2 = new int[num];
            for (int i = 0; i < flower1.Length; i++)
            {
                Console.Write($"enter the code of the {i + 1} flower: ->");
                flower1[i] = int.Parse(Console.ReadLine());
            }
            int cnt2 = 0;
            for (int i = 0; i < flower1.Length; i++)
            {
                if (flower1[i] / 100 == 2)
                {
                    flower2[cnt2] = flower1[i];
                    flower1[i] = 0;
                    cnt2++;
                }
            }
            int cnt = 0;
            for (int i = 0; i < flower1.Length; i++)
            {
                if (flower1[i] != 0)
                {
                    flower1[cnt] = flower1[i];
                    cnt++;
                }
            }
            for (int i = cnt; i < flower1.Length; i++)
            {
                flower1[i] = 0;
            }

            PrintArr(flower1);
            PrintArr(flower2);
        }
    }
}
