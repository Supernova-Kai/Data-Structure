/*
 * 线性查找，也叫顺序查找
 * 
 * 原理：从集合的一端，一直遍历，直到找到为止
 * 
 * 时间复杂度最好情况：O(1) 找的元素刚好在第一个
 * 时间复杂度最坏情况：O(n) 元素不在集合里面，需要遍历完整个集合
 * 时间复杂度一般取最坏的情况，线性查找的时间复杂度便是O(n)
 */

public partial class Search
{
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
