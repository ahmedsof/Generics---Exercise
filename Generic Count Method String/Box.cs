using System;
using System.Collections.Generic;
using System.Text;

namespace GenericSwapMethodString
{
    public class Box<T> where T: IComparable
    {

        public List<T> Values { get; set; } = new List<T>();

        public Box(List<T> values)
        {
            this.Values = values;
        }

        public void Swap(int first, int second)
        {
            var tempValue  = this.Values[first];
            this.Values[first] = this.Values[second];
            this.Values[second] = tempValue;
        }

        public int GetCountOfGreaterValues(T value)
        {

            int counter = 0;

            foreach (T currentValue in this.Values)
            {
                if (value.CompareTo(currentValue) < 0)
                {
                    counter++;
                }
                
            }
            return counter;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (T value in this.Values)
            {
                sb.AppendLine($"{value.GetType()}: {value}");
            }
            return sb.ToString().Trim();
        }
    }   
}
