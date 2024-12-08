using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfOddEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> originalList = new LinkedList<int>();
            originalList.AddLast(1);
            originalList.AddLast(2);
            originalList.AddLast(3);
            originalList.AddLast(4);
            originalList.AddLast(5);

            var evenList = SplitList(originalList, "even");
            var oddList = SplitList(originalList, "odd");

            Console.WriteLine("Списък с четни числа:");
            PrintList(evenList);

            Console.WriteLine("Списък с нечетни числа:");
            PrintList(oddList);
        }

        static List<int> SplitList(LinkedList<int> list, string numberType)
        {
            List<int> splitNumbers = new List<int>();
            foreach (var item in list)
            {
                if (numberType == "even" && item % 2 == 0)
                {
                    splitNumbers.Add(item);
                }
                else if (numberType == "odd" && item % 2 != 0)
                {
                    splitNumbers.Add(item);
                }
            }
            return splitNumbers;
        }

        static void PrintList(List<int> numberList)
        {
            Console.WriteLine(string.Join(" ", numberList));
        }
    }
}
