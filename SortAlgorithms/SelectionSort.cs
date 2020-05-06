using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms
{
    static class SelectionSort
    {
        static public void Sort(int[] MyArray)
        {
            int Index;
            for (int i = 0; i < MyArray.Length; i++)
            {
                Index = -1;
                int min = MyArray[i];
                for (int a = i; a < MyArray.Length; a++)
                {
                    if (MyArray[a] < min)
                    {
                        min = MyArray[a];
                        Index = a;
                    }
                }
                if (Index != -1)
                {
                    Console.WriteLine(MyArray[Index]);
                    Reverse(ref MyArray[i], ref MyArray[Index]);
                }
            }
        }

        static private void Reverse(ref int FirstValue, ref int SecondValue)
        {
            int temp = FirstValue;
            FirstValue = SecondValue;
            SecondValue = temp;
        }
    }
}
