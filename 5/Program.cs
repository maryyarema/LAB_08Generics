using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class Program
    {
        static int Count<T1>(List<GenericBox<T1>> boxes, T1 value) where T1 : IComparable<T1>
        {
            int result = 0;
            for (int i = 0; i < boxes.Count; i++)
            {
                var box = boxes[i].Value;
                if (box.CompareTo(value) > 0)
                {
                    result++;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var boxes = new List<GenericBox<string>>();
            for (int i = 0; i < n; i++)
            {
                string integer = Console.ReadLine();
                boxes.Add(new GenericBox<string>(integer));
            }
            string value = Console.ReadLine();
            int result = Count(boxes, value);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}