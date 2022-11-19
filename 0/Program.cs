using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int integer = int.Parse(Console.ReadLine());
                var result = new GenericBox<int>(integer);
                Console.WriteLine(result.ToString());
            }
            Console.ReadLine();
        }
    }
}