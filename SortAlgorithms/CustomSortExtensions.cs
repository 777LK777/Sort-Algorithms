using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms
{
    public static class CustomSortExtensions
    {
        public static void BubbleSort<T>(this List<T> unsortedList, IComparer<T> comparer)
        {
            if (unsortedList.Count == 0) return;

            bool wasReversed = false;

            do
            {
                for(int i = 1; i < unsortedList.Count; i++)
                {
                    int result = comparer.Compare(unsortedList[i], unsortedList[i - 1]);





                }




            }
            while (wasReversed);



        }
    }
}
