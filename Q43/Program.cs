using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q43
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] lastFix = new char[15];
            char[] beforeLastFix = new char[15];
            for (int i = 0; i < lastFix.Length; i++)
            {
                Console.Write("enter the name of the boat that was in the last maintance: ");
                lastFix[i] = char.Parse(Console.ReadLine());
            }
            for (int i = 0; i < beforeLastFix.Length; i++)
            {
                Console.Write("enter the name of the boat that was in the maintance before the last maintance: ");
                beforeLastFix[i] = char.Parse(Console.ReadLine());
            }

            int allBoatsToFix = 30;
            for (int i = 0; i < 15; i++)
            {
                if (lastFix.Contains(beforeLastFix[i]))
                {
                    allBoatsToFix -= 2;
                }
            }
            char[] totalBoats = new char[allBoatsToFix];
            int newStart = 0;

            for (int i = 0; i < 15; i++)
            {
                if (!lastFix.Contains(beforeLastFix[i]))
                {
                    totalBoats[newStart] = beforeLastFix[i];
                    newStart++;
                }
            }
            for (int i = 0; i < 15; i++)
            {
                if (!beforeLastFix.Contains(lastFix[i]))
                {
                    totalBoats[newStart] = lastFix[i];
                }
            }

            Console.Write($"{totalBoats[0]}");
            for (int i = 1; i < totalBoats.Length; i++)
            {
                Console.Write($", {totalBoats[i]}");
            }
        }
    }
}
