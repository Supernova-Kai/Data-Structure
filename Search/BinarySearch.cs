/*
 * 二分查找
 * 
 * 首先，使用二分查找的前提条件是：需要查找的集合必须是有序的！！！
 * 
 * 原理：
 * 1、有一个搜索范围的左右边界（没有被排除的集合部分）
 * 2、找出中间位置
 * 3、将中间位置的值与目标值比较
 * 4、根据比较结果调整左右边界，即搜索范围
 * 5、重复以上步骤，直到找到目标值为止
 * 
 * 时间复杂度：最差的情况就是集合里面没有这个元素，但是因为每一次都能排除一半的元素，所以时间复杂度是O(log2n)
 * 
 * 用于二分查找的集合，必须确保集合本身有序！！！
 */

public partial class Search
{
    // 这里的array必须是排好序之后的数组
    public static bool BinarySearch(int[] array, int target)
    {
        int left = 0; //左边界
        int right = array.Length - 1; //右边界

        while (left <= right)
        {
            int mid = left + (right - left) / 2; //中间索引，这里不用(left + right) / 2 的原因是，防止超出int的上限
            int midValue = array[mid]; //中间值

            if (midValue == target) //等于目标值，直接返回
            {
                return true;
            }
            else if (midValue < target) //中间值小于目标值，说明目标值在中间值的右边
            {
                left = mid + 1; //调整左边界，因为中间索引也不等于目标值，这里是mid + 1
            }
            else if (midValue > target) //中间值大于目标值，说明目标值在中间值的左边
            {
                right = mid - 1; //调整右边界，因为中间索引也不等于目标值，这里是mid - 1
            }
        }
        return false; //一定不要忘了处理没找到的情况
    }
}