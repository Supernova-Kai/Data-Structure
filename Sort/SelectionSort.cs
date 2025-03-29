/*
 * 选择排序
 * 
 * 原理：
 * 1、在未排序部分选出最大或最小的元素（取决升序还是降序）
 * 2、将其与未排序部分的第一或者最后一个（取决升序还是降序）元素交换
 * 3、重复以上步骤，直到完成
 */

public partial class Sort
{
    /*
     * 这里我们以升序为例，每一次找出未排序部分的最小元素，并将它放到最前面
     */
    public static void SelectionSort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int minIndex = i; //因为要与未排序部分最前面的值交换，暂且认为未排序部分的第一个元素是最小的
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[minIndex])
                {
                    minIndex = j; //找到更小的就更新索引
                }
            }

            if (minIndex != i)
            {
                int temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
            }
        }
    }
}