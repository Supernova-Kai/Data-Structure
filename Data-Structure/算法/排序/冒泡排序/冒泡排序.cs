public partial class Sort 
{
    public static void BubbleSort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++) //集合长度为n，只需要n-1次就可完成排序
        {
            for (int j = 0; j < array.Length - 1 - i; j++) //从前到尾进行冒泡，未排序部分最大的数便会不断冒泡到末尾
            {
                if (array[j + 1] < array[j])
                {
                    int temp = array[j + 1];
                    array[j + 1] = array[j];
                    array[j] = temp;
                }
            }
        }
    }
}