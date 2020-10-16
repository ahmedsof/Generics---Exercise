using System;

namespace GenericBoxofString
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string input = Console.ReadLine();

                Box<string> box = new Box<string>(input);

                Console.WriteLine(box.ToString());
            }
        }
    }
}
