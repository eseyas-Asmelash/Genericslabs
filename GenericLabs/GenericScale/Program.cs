using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericScale
{
    class Program
    {
        static void Main(string[] args)
        {
            Scale<bool> box = new Scale<bool>(true, true);
            Console.WriteLine(box.GetHeavier());
            Console.Read();
        }
    }
}
