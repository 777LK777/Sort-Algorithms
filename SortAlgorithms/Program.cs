using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] MyArray = new int[]
            {
                5,
                6,
                8,
                1,
                2,
                5,
                9,
                11,
                15,
                1,
                4,
                3,
                2,
                1
            };

            BubbleSort.Sort(MyArray);

            foreach (int i in MyArray)
                Console.Write(i + "\t");

            Console.ReadKey();
        }
    }
}
