using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.IO;
class Test
{
//    编写一个函数来查找字符串数组中的最长公共前缀。
//如果不存在公共前缀，返回空字符串 ""。
//示例 1:
//输入: ["flower","flow","flight"]
//    输出: "fl"
//示例 2:
//输入: ["dog","racecar","car"]
//    输出: ""
//解释: 输入不存在公共前缀。
//说明:
//所有输入只包含小写字母 a-z 。
    #region 思路
        // 两重循环 以字符串的长度 以字符串数组的长度进行循环，一不满足立刻输出。主要数组越界先找到最小字符串
    #endregion



    static void Main()
    { 
    }
    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0) return "";
            if (strs.Length == 1) return strs[0];
            var min = int.MaxValue;
            foreach (var item in strs)
            {
                if (item.Length < min) min = item.Length;
            }
            var index = -1;
            for (var i = 0; i < min; i++)
            {
                for (var j = 1; j < strs.Length; j++)
                {

                    if (strs[j][i] != strs[0][i]) return strs[0].Substring(0, i);
                    else
                    {
                        index = i;
                    }
                }
            }
            return strs[0].Substring(0, index + 1);

        }
    }


}
