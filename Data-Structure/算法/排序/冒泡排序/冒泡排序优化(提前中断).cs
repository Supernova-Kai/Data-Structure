public partial class Sort
{
    public static void BubbleSort2(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            bool swapped = false;  // 标记本轮是否发生过交换
            for (int j = 0; j < array.Length - 1 - i; j++)
            {
                if (array[j + 1] < array[j])
                {
                    int temp = array[j + 1];
                    array[j + 1] = array[j];
                    array[j] = temp;
                    swapped = true;  // 发生交换，标记为 true
                }
            }

            if (!swapped)  // 如果本轮没有交换，说明数组已经有序，提前结束
            {
                break;
            }
        }
    }
}