using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsArrayCreator
{
    public class ArrayCreator
    {
        public static T[] Create<T>(int length, T item)
        {
            var start = new T[length];
            for(int i=0; i < length; i++)
            {
                start[i] = item;
            }
            return start;
        }

    }
}
