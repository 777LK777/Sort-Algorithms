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
            for (int i = 0; i < MyArray.Length; i++)
            {                
                for (int a = i; a < MyArray.Length; a++)
                {                                        
                    if (MyArray[a] < MyArray[i])
                    {
                        Reverse(ref MyArray[i], ref MyArray[a]);
                    }                                          
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
