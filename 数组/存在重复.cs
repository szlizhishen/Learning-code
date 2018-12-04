﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace lianxi
{
//给定一个整数数组，判断是否存在重复元素。
//如果任何值在数组中出现至少两次，函数返回 true。如果数组中每个元素都不相同，则返回 false。
//示例 1:
//输入: [1,2,3,1]
//输出: true
//示例 2:
//输入: [1,2,3,4]
//输出: false
//示例 3:
//输入: [1,1,1,3,3,4,3,2,4,2]
//输出: true


    #region 思路
        // 先排序后再找相邻是否相等
    #endregion

    class Program
    {
        static void Main(string[] args)
        {

        }
        public class Solution
        {
            public bool ContainsDuplicate(int[] nums)
            {
                List<int> num = new List<int>(nums);
                num.Sort();
                for (int i = 1; i < num.Count; i++)
                {
                    if (num[i] - num[i - 1] == 0)
                    {
                        return true;
                    }
                }
                return false;
            }

        }



    }
}
