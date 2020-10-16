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
            List<string> values = new List<string>();

            for (int i = 0; i < input; i++)
            {
                string currentValue = Console.ReadLine();
                values.Add(currentValue);
            }

            string valueToCompare = Console.ReadLine();

            Box<string> box = new Box<string>(values);

            int greatValue = box.GetCountOfGreaterValues(valueToCompare);
            Console.WriteLine(greatValue);
        }
    }
}
