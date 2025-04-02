/*
 * 查重问题：
 * 有一个数组，通过一个算法判断数组内有没有重复的元素
 * 
 */

public class FindDuplicate
{
    /*
     *  暴力解法
     *  通过两层循环嵌套寻找是否有重复
     *  时间复杂度：O(n^2)
     *  空间复杂度：O(1)
     */
    public static bool ContainsDuplicate(int[] num)
    {
        for (int i = 0; i < num.Length; i++)
        {
            for (int j = i + 1; j < num.Length; j++)
            {
                if (num[i] == num[j])
                {
                    return true;
                }
            }
        }
        return false;
    }

    /*
     * 优化后的算法
     * 只需要一层循环，将已经遍历过的元素存入缓存中
     * 后面只需要检查是否在缓存中已经存在，便可知道是否重复
     * 时间复杂度：最坏情况下就是没有重复元素，需要遍历完整个集合，为O(n)
     * 空间复杂度：最坏情况下就是没有重复元素，会缓存整个集合所有元素，为O(n)
     * 这是一种以“空间换时间”的策略
     */
    public static bool ContainsDuplicate2(int[] num)
    { 
        HashSet<int> cache = new HashSet<int>(); //缓存
        for (int i = 0; i < num.Length; i++)
        {
            if (cache.Contains(num[i]))
                return true;

            cache.Add(num[i]);
        }
        return false;
    }
}
