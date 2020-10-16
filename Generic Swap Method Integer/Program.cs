using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodString
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            List<int> values = new List<int>();

            for (int i = 0; i < input; i++)
            {
                int currentValue = int.Parse(Console.ReadLine());
                values.Add(currentValue);
            }

            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int first = indexes[0];
            int second = indexes[1];

            Box<int> box = new Box<int>(values);

            box.Swap(first, second);
            Console.WriteLine(box);
        }
    }
}
