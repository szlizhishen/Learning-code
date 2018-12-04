﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace lianxi
{
    /// <summary>
    /// 从排序数组中删除重复项
    /// 给定一个排序数组，你需要在原地删除重复出现的元素，使得每个元素只出现一次，返回移除后数组的新长度。
    ///不要使用额外的数组空间，你必须在原地修改输入数组并在使用 O(1) 额外空间的条件下完成。//
    ///示例 1:
    ///给定数组 nums = [1, 1, 2],
    ///函数应该返回新的长度 2, 并且原数组 nums 的前两个元素被修改为 1, 2。 
    ///你不需要考虑数组中超出新长度后面的元素。
    ///示例 2:
    ///给定 nums = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4],
    ///函数应该返回新的长度 5, 并且原数组 nums 的前五个元素被修改为 0, 1, 2, 3, 4。
    ///你不需要考虑数组中超出新长度后面的元素。
    /// </summary>
    /// <param name="args"></param>


    #region 思路
        //因为是排序好的只要比对前一个是不是相同就可以了
        //这里用了temp做不重复输出的指针
    #endregion

    class Program
    { 
        static void Main(string[] args)
        {

        }
        public class Solution
        {
            public int RemoveDuplicates(int[] nums)
            {
                int temp = 1;
                if (nums.Length == 0)
                    return 0;
                if (nums.Length == 1)
                    return 1;
                for (int i = 1; i < nums.Length; ++i)
                {
                    if (nums[i] != nums[i - 1])
                    {
                        nums[temp] = nums[i];
                        temp++;
                    }
                }
                return temp;
            }
        }
    }
}
