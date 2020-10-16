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
            List<String> values = new List<string>();

            for (int i = 0; i < input; i++)
            {
                string currentValue = Console.ReadLine();
                values.Add(currentValue);
            }

            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int first = indexes[0];
            int second = indexes[1];

            Box<string> box = new Box<string>(values);

            box.Swap(first, second);
            Console.WriteLine(box);
        }
    }
}
