public partial class Search
{
    /*
     * 线性查找,遍历整个集合
     * 时间复杂度 O(n)
     * 空间复杂度 O(1)
     */
    public static bool LinearSearch(int[] array, int target)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == target)
            {
                return true; //找到了
            }
        }
        return false; //没找到
    }
}