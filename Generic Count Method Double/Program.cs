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
            List<double> values = new List<double>();

            for (int i = 0; i < input; i++)
            {
                double currentValue = double.Parse(Console.ReadLine());  
                values.Add(currentValue);
            }

            double valueToCompare = double.Parse(Console.ReadLine());

            Box<double> box = new Box<double>(values);

            double greatValue = box.GetCountOfGreaterValues(valueToCompare);
            Console.WriteLine(greatValue);
        }
    }
}
