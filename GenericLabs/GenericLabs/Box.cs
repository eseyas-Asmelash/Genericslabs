using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericLabs
{
    class Box<T>
    {
        private List<T> start = new List<T>();
        public int Count { get { return start.Count; } }

        public void Add(T i)
        {
            start.Add(i);
        }
        public T Remove()
        {
            T temp = start[start.Count - 1];
            start.RemoveAt(start.Count - 1);
            return temp;
        }
    }
}
