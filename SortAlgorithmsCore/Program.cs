using CustomSorts;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace SortAlgorithmsCore
{
    class M
    {
        public int Digit { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<int> unsList = new List<int>
            {
                10, // 0
                -1, // 1
                8,  // 2
                15, // 3
                23, // 4
                -100,   //5
                -16 //6
            };

            unsList.InsertionSort();

            //unsList.SelectionSort();

            //unsList.BubbleSort();

            List<char> charList = new List<char>
            {
                'z',
                'x',
                'a',
                'r',
                ' ',
                '/',
                '-'
            };

            charList.InsertionSort();
        }
    }
}
