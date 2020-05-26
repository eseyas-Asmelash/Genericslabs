using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericScale
{
    class Scale<T> where T : IComparable
    {
        public T Left { get; set; }
        public T Right { get; set; }
        public Scale(T left, T right)
        {
            Left = left;
            Right = right;
        }

        public T GetHeavier()
        {
            T value = default(T);
            int a = Left.CompareTo(Right);

            if (a == 0)
                value = default(T);
            else if (a == -1)
                value = Right;
            else if (a == 1)
                value = Left;
            return value;
        }
    }
}
