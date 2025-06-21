public partial class Sort
{
    public static void InsertionSort(int[] array)
    {
        for (int i = 1; i < array.Length; i++) //从第二张“牌”开始（相当假定第一张“牌”是有序部分，后面都是无序部分）
        {
            int currentNum = array[i]; //无序部分选出一张“牌”，这里就选无序部分的第一张牌
            int j = i - 1; //有序部分最后一张“牌”的索引

            while (j >= 0 && array[j] > currentNum) //这里从后往前遍历，如果遇到了比我们大的“牌”，就把它后移
            {
                array[j + 1] = array[j]; //后移元素
                j--; //更新索引，继续向前找
            }

            //从while循环出来了，要么就是走到头了（说明选中的“牌”比有序部分所有的“牌”都小）
            //要么就是遇到了一张我们小的“牌”
            array[j + 1] = currentNum; //因为前面已经后移过元素了，这个位置已经是一个“空洞”，直接赋值即可
        }
    }
}