/*
 * 选择排序
 * 时间复杂度：O(n^2)
 * 相比于冒泡排序，内层循环只有一次交换的步骤，性能相比于冒泡排序更高
 * 空间复杂度：不开辟新空间，为O(1)
 */

public partial class Sort
{
    public static void SelectionSort(int[] array)
    {
        // 外层for循环，控制轮数，这里的i理解成，索引i需要找到一个正确的值，那么我们需要在未排序部分找到最小值，并将它与索引i交换
        // 假设我们有个数组，长度为5，其实只需要4轮便可以排完序列，因为选择排序最终是交换两个元素的位置，如果第4轮出现最后两个元素错误
        // 交换之后它们其实都已经处于正确的位置了，不需要在走一轮
        // 所以外层循环的轮数是长度减一
        for (int i = 0; i < array.Length - 1; i++) // i理解为“索引i需要一个正确的值”
        {
            int minIndex = i; //先假定索引i是最小的

            //下面的循环用于在未排序部分中找到最小的元素
            for (int j = i + 1; j < array.Length; j++) //未排序部分就是索引i之后的部分
            {
                if (array[j] < array[minIndex])
                {
                    minIndex = j; //找到更小的元素就更新索引
                }
            }

            if (minIndex != i)
            {
                //交换索引i与最小值的索引，那么索引i就是正确的值了
                int temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
            }
        }
    }
}