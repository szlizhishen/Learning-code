using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace lianxi
{
//给定两个数组，编写一个函数来计算它们的交集。
//示例 1:
//输入: nums1 = [1,2,2,1], nums2 = [2,2]
//输出: [2,2]
//示例 2:
//输入: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
//输出: [4,9]
//说明：
//输出结果中每个元素出现的次数，应与元素在两个数组中出现的次数一致。
//我们可以不考虑输出结果的顺序。
//进阶:
//如果给定的数组已经排好序呢？你将如何优化你的算法？
//如果 nums1 的大小比 nums2 小很多，哪种方法更优？
//如果 nums2 的元素存储在磁盘上，磁盘内存是有限的，并且你不能一次加载所有的元素到内存中，你该怎么办？


    #region 思路
    // 使用哈希表 将一的元素写入 值为其出现次数，再将二进行查表，每次查到重合就将值减少并存到链表里。
    // 若给定的都是排序好的只需要两个指针分别遍历数组
    // 若内存有限 则应该分布统计再初始化nums1
    #endregion

    class Program
    {
        static void Main(string[] args)
        {

        }
        public class Solution
        {
            public int[] intersect(int[] nums1,int[] nums2)
            {
                Hashtable table = new Hashtable(nums1.Length);
                for(int i = 0; i < nums1.Length; i++)
                {
                    int num = nums1[i];
                    if (table.ContainsKey(num))
                    {
                        table[num]= (int)table[num] + 1;
                    }
                    else
                    {
                        table.Add(num, 1);
                    }
                }
                List<int> tempList = new List<int>();
                for(int i = 0; i < nums2.Length; i++)
                {
                    int num = nums2[i];
                    if (table.ContainsKey(num) && (int)table[num] > 0)
                    {
                        table[num] = (int)table[num] - 1;
                        tempList.Add(num);
                    }
                }
                int[] result = new int[tempList.Count];
                for(int i = 0; i < result.Length; i++)
                {
                    result[i] = tempList[i];
                }
                return result;
            }

        }





    }
}
