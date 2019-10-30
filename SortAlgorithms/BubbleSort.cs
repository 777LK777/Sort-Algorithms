using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms
{
    static class BubbleSort
    {
        static bool WasReversed = false;

        /// <summary>
        /// Непосредственно сортировка
        /// </summary>
        /// <param name="Array">Сортируемый массив</param>
        /// <returns>Возвращает отсортированную последовательность</returns>
        static public IEnumerable<int> Sort(int[] Array)
        {
            if (Array.Count() > 1)
            {
                do
                {
                    //Всё что было до меня обнуляй
                    WasReversed = false;

                    for (int i = 1; i < Array.Count(); i++)
                    {
                        Reverse(ref Array[i - 1], ref Array[i]);
                    }
                } while (WasReversed);               

                return Array;
            }
            else
            {
                throw new InvalidOperationException("Количество элементов массива должно быть больше одного");
            }
            
        }

        /// <summary>
        /// Меняет местами числа, если большее находится раньше
        /// </summary>
        /// <param name="FirstBubble">Число с меньшим индексом</param>
        /// <param name="SecondBubble">Число с большим индексом</param>
        static void Reverse(ref int FirstBubble, ref int SecondBubble)
        {
            if(FirstBubble > SecondBubble)
            {
                int temp = SecondBubble;
                SecondBubble = FirstBubble;
                FirstBubble = temp;
                WasReversed = true;
            }            
        }
    }
}
