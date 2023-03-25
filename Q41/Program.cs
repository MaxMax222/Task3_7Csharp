using System;

namespace Q41
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
            int cntNeg = 0, cntEven = 0, num;
            Console.Write("enter how many number you're about to insert: ->");
            num = int.Parse(Console.ReadLine());
            int[] number = new int[num];
            for (int i = 0; i < number.Length; i++)
            {
                Console.Write("enter a number: ->");
                number[i] = int.Parse(Console.ReadLine());
                if (number[i] % 2 == 0 && number[i] < 0)
                {
                    cntEven++;
                    cntNeg++;
                }
                else if (number[i] < 0)
                {
                    cntNeg++;
                }
                else if (number[i] % 2 == 0)
                {
                    cntEven++;
                }
            }

            int[] evenArr = new int[cntEven];
            int cnt = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] % 2 == 0)
                {
                    evenArr[cnt] = number[i];
                    cnt++;
                }
            }

            int[] negArr = new int[cntNeg];
            cnt = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] < 0)
                {
                    negArr[cnt] = number[i];
                    cnt++;
                }
            }

            Console.WriteLine("all even numbers: ");
            PrintArr(evenArr);
            Console.WriteLine("all negative numbers");
            PrintArr(negArr);
        }
    }
}
