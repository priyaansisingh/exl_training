using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    
    internal class Program4
    {
        static void Main(string[] args)
        {
            int[] numbers = { 34000, 24000, 31000, 28000, 29000, 33000 };

            var result = numbers.Select(x => x * 1.03);

            foreach (var i in result)
            {
                Console.WriteLine(i);
            }
        }
    }
}
