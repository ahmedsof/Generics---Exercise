using System;
using System.Collections.Generic;
using System.Text;

namespace GenericSwapMethodString
{
    public class Box<T>
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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (T value in this.Values)
            {
                sb.AppendLine($"{value.GetType()}: {value}");
            }
            return sb.ToString();
        }
    }   
}
