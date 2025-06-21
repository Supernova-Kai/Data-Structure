public partial class Search
{
    /*
     * 二分查找
     * 使用前提条件：集合必须本身有序
     * 时间复杂度 O(log2n)
     * 空间复杂度 O(1)
     */
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