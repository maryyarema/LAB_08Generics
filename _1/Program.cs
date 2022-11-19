using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string str = Console.ReadLine();
                var result = new GenericBox<string>(str);
                Console.WriteLine(result.ToString());
            }
            Console.ReadLine();
        }
    }
}