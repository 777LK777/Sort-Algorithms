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
                5,  //0
                6,  //1
                8,  //2
                1,  //3
                2,  //4
                5,  //5
                9,  //6
                11, //7
                15, //8
                1,  //9
                4,  //10
                3,  //11
                2,  //12
                1,  //13
                -1  //14
            };

            //BubbleSort.Sort(MyArray);
            SelectionSort.Sort(MyArray);



            foreach (int i in MyArray)
                Console.Write(i + "\t");

            Console.ReadKey();
        }
    }
}
