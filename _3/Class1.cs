using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class GenericBox<T>
    {
        public T Value;
        public GenericBox(T value)
        {
            Value = value;
        }
        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine(Value.GetType().FullName + " : " + Value);
            string result = resultBuilder.ToString().TrimEnd();
            return result;
        }
    }
}