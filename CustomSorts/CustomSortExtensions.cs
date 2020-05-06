using System.Collections.Generic;

namespace CustomSorts
{
    public static class CustomSortExtensions
    {
        public static void BubbleSort<T>(this List<T> unsortedList, IComparer<T> comparer)
        {
            if (unsortedList.Count < 2) return;

            bool wasReversed;

            do
            {
                wasReversed = false;

                for(int i = 1; i < unsortedList.Count; i++)
                {
                    if (comparer.Compare(unsortedList[i], unsortedList[i - 1]) < 0)
                    {
                        unsortedList.Reverse(i - 1, 2);
                        wasReversed = true;
                    }
                }
            }
            while (wasReversed);
        }

        public static void BubbleSort<T>(this List<T> unsortedList)
        {
            unsortedList.BubbleSort(Comparer<T>.Default);
        }

        private static void Reverse<T>(this List<T> list, int firstIndex, int secondIndex)
        {
            if (list.Count < 2) return;

            T temp = list[firstIndex];
            list[firstIndex] = list[secondIndex];
            list[secondIndex] = temp;
        }

        public static void SelectionSort<T>(this List<T> unsortedList, IComparer<T> comparer)
        {
            if (unsortedList.Count < 2) return;

            for (int startIndex = 0; startIndex < unsortedList.Count; startIndex++)
            {
                int minIndex = startIndex;
                T minElement = unsortedList[minIndex];

                for (int i = startIndex + 1; i < unsortedList.Count; i++)
                {
                    if(comparer.Compare(unsortedList[i], unsortedList[i - 1]) < 0)
                    {
                        minIndex = i;
                        minElement = unsortedList[i];
                    }
                }

                if (startIndex != minIndex) unsortedList.Reverse(firstIndex: startIndex, secondIndex: minIndex);
            }
        }

        public static void SelectionSort<T>(this List<T> unsortedList)
        {
            unsortedList.SelectionSort(Comparer<T>.Default);
        }

        public static void InsertionSort<T>(this List<T> unsortedList, IComparer<T> comparer)
        {
            if (unsortedList.Count < 2) return;

            for(int currentIndex = 1; currentIndex < unsortedList.Count; currentIndex++)
            {
                for(int i = currentIndex;
                    i > 0
                    && comparer.Compare(unsortedList[i], unsortedList[i - 1]) < 0;
                    i--)
                {
                    unsortedList.Reverse(firstIndex: i, secondIndex: i - 1);
                }
            }
        }

        public static void InsertionSort<T>(this List<T> unsortedList)
        {
            unsortedList.InsertionSort(Comparer<T>.Default);
        }
    }
}
