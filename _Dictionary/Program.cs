using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            _Dictionary<int, string> dict = new _Dictionary<int, string>();
            dict.Add(1, "Arm");
            dict.Add(2, "Ars");
            dict.Add(3, "Vzg");

            string name = dict[2];

            Console.WriteLine(name);

            Console.ReadKey();

        }
    }
}
