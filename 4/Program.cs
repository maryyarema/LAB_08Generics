using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class Program
    {
        static void Swap<T>(ref List<GenericBox<T>> boxes, int[] items)
        {
            var temp = boxes[items[0]];
            boxes[items[0]] = boxes[items[1]];
            boxes[items[1]] = temp;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var boxes = new List<GenericBox<int>>();
            for (int i = 0; i < n; i++)
            {
                int integer = int.Parse(Console.ReadLine());
                boxes.Add(new GenericBox<int>(integer));
            }
            int[] items = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Swap(ref boxes, items);
            foreach (var item in boxes)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();
        }
    }
}