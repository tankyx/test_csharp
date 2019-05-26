using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_1
{
    class Program
    {
        static int findHighest(int []ints, int szInts)
        {
            int highest = ints[0];
            int index = 0;

            while (index < szInts)
            {
                if (highest < ints[index])
                    highest = ints[index];
                index++;
            }
            return highest;
        }

        static void Main(string[] args)
        {
            int []ints = { -5, -10, 3, 50, 10, 2 };

            Console.Write(findHighest(ints, ints.Length));
        }
    }
}
