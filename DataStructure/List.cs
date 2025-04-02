/*
 * C#中的List<T>，本质上是一个动态数组
 * 其在内存中维护了一个T类型数组(即T[])
 *
 * 由于数组本身的大小不可进行修改，List底层实现了一套对T[]空间进行管理的方法
 * 大致规则如下：
 * 1、List初始化时，其会被分配一个长度为0的数组
 * 2、当第一次添加元素时，容量会扩展为4
 * 3、当因为添加元素导致容量不足时，List会创建一个长度为当前容量两倍的新数组并拷贝原有元素
 *
 * List我们常用的属性是Count，这是List实际包含的元素数量
 * List还有一个属性是Capacity，其表示这个T[]数组真正的空间大小
 * 注意：在删除List元素时，List是减少Count的值，将被删除元素的位置标记为可重用，不会对容量进行自动缩减(Capacity不会减少)
 * 比如：我们对一个List添加10个元素，由于初始容量是4，并且以两倍的方式进行扩容，那么List最终应该是分配了16个空间
 * 但是我们不断删除元素，即使删除到只剩一个或者直接调用List.Clear()方法将元素清空，其空间仍然是16个空间不会自动减少
 * 不过我们可以调用TrimExcess()方法对列表的空间进行重新分配
 * 如果列表不再用了，可以考虑直接置为null，让GC回收
 *
 * 访问元素（读取）：
 * 由于其底层是一个数组，通过地址可以直接访问，时间复杂度为O(1)
 *
 * 添加元素操作，分两种情况：
 * 1、在末尾添加元素：
 * 如果数组有剩余空间，不需要扩容的时候，其只是一个简单的赋值操作，时间复杂度为O(1)
 * 如果数组剩余空间不足，需要扩容，需要分配新的数组，遍历旧数组的所有元素，并拷贝到新数组，时间复杂度为O(n)

 * 2、在任意元素插入元素：
 * 最坏情况，在开头插入元素，需要移动后面所有元素的位置，时间复杂度为O(n)
 * 最好情况，在末尾插入，不扩容的情况下是O(1)
 * 时间复杂度取最坏的情况，综合下来是O(n)
 *
 * 删除元素：
 * 最好情况，删除最后一个元素，时间复杂度为O(1)
 * 最坏情况，删除第一个元素，需要向前移动后面的每一个元素，时间复杂度为O(n)
 * 综上，时间复杂度为O(n)
 *
 * 查找元素：
 * C#中List的查找方法Contains()，其底层是线性查找算法，时间复杂度为O(n)
 *
 */