using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    public static class Sorter
    {
        public static void Sort<T>(CustomList<T> list)
            where T : IComparable<T>
        {
            list.Sort();
        }
    }
}