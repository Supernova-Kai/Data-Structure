﻿public partial class Sort
{
    public static void TwoWayBubbleSort(int[] array)
    {
        int start = 0;
        int end = array.Length - 1;

        do
        {
            // 从左到右，把最大的元素推到右边
            for (int i = start; i < end; i++)
            {
                if (array[i] > array[i + 1])
                {
                    int temp = array[i + 1];
                    array[i + 1] = array[i];
                    array[i] = temp;
                }
            }

            end--; // 最右边已经有序，缩小范围


            // 从右到左，把最小的元素推到左边
            for (int i = end - 1; i >= start; i--)
            {
                if (array[i] > array[i + 1])
                {
                    int temp = array[i + 1];
                    array[i + 1] = array[i];
                    array[i] = temp;
                }
            }

            start++; // 最左边已经有序，缩小范围
        } while (start <= end);
    }
}