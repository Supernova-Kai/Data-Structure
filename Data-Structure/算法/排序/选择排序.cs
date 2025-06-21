public partial class Sort
{
    public static void SelectionSort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++) // i可以理解为“索引i需要一个正确的值”
        {
            int minIndex = i; //先假定索引i是最小的

            //下面的循环用于在未排序部分中“选择”出最小的元素
            for (int j = i + 1; j < array.Length; j++) //未排序部分就是索引i之后的部分
            {
                if (array[j] < array[minIndex])
                {
                    minIndex = j; //找到更小的元素就更新索引
                }
            }

            if (minIndex != i)
            {
                // 交换元素
                int temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
            }
        }
    }
}