using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomList<string> customList = new CustomList<string>();
            while (true)
            {
                string[] strarray = Console.ReadLine().Split(' ').ToArray();
                if (strarray[0] == "Add")
                {
                    customList.Add(strarray[1]);
                }
                else if (strarray[0] == "Remove")
                {
                    customList.Remove(int.Parse(strarray[1]));
                }
                else if (strarray[0] == "Contains")
                {
                    Console.WriteLine(customList.Contains(strarray[1]));
                }
                else if (strarray[0] == "Swap")
                {
                    customList.Swap(int.Parse(strarray[1]), int.Parse(strarray[2]));
                }
                else if (strarray[0] == "Greater")
                {
                    Console.WriteLine(customList.CountGreaterThan(strarray[1]));
                }
                else if (strarray[0] == "Max")
                {
                    Console.WriteLine(customList.Max());
                }
                else if (strarray[0] == "Min")
                {
                    Console.WriteLine(customList.Min());
                }
                else if (strarray[0] == "Print")
                {
                    foreach (var str in customList)
                    {
                        Console.WriteLine(str);
                    }
                }
                else if (strarray[0] == "Sort")
                {
                    Sorter.Sort(customList);
                }
                else
                {
                    break;
                }
            }
        }
    }
}