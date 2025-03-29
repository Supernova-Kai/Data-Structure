/*
 * 冒泡排序，也可以叫沉降排序
 * 因为在每一次执行的时候，值较大的数字不断往集合后面走（往上冒）；值较小的数字不断往集合前面走（往下降），所以叫冒泡排序或者沉降排序
 * 时间复杂度：O(n^2)
 * 但是内层循环要不断比较与交换相邻的元素，步骤较多，性能较差
 * 空间复杂度：不开辟新空间，为O(1)
 * 
 */

public partial class Sort
{
    //以较小元素不断左移为例
    public static void BubbleSort(int[] array)
    {
        //外层循环控制轮数，因为是交换元素，只剩两个元素的时候，交换之后没必要再进行一次操作，所以i是从0到长度减一
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = array.Length - 1; j > i; j--) //因为我们是把较小元素左移，所以从后往前遍历
            {
                if (array[j] < array[j - 1]) //如果右边的元素比左边的小，交换它们
                {
                    int temp = array[j];
                    array[j] = array[j - 1];
                    array[j - 1] = temp;
                }
            }
        }
    }
}