/*
 * 线性查找，也叫顺序查找
 * 
 * 原理：从集合的一端，一直遍历，直到找到为止
 * 
 * 时间复杂度：
 * 最好情况：找的元素刚好在第一个，为O(1)
 * 最坏情况：元素不在集合里面或者在最后一个，需要遍历完整个集合，为O(n) 
 * 时间复杂度一般取最坏的情况，线性查找的时间复杂度便是O(n)
 * 
 * 空间复杂度：
 * 未开辟新空间，为O(1)
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
