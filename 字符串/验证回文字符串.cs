using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
class Test
{
//    给定一个字符串，验证它是否是回文串，只考虑字母和数字字符，可以忽略字母的大小写。
//说明：本题中，我们将空字符串定义为有效的回文串。
//示例 1:
//输入: "A man, a plan, a canal: Panama"
//输出: true
//示例 2:
//输入: "race a car"
//输出: false

    #region 思路
        // 两边遍历，先去除不符合的字符，再进行前后判断
    #endregion



    static void Main()
    {
        Console.Write(" ");
        Console.ReadKey();
    }
    public class Solution
    {
        public bool IsPalindrome(string s)
        {
            s = s.ToLower().Trim();
            var list = new List<char>();
            foreach (var c in s)
            {
                if ((c >= 48 && c <= 57) || (c >= 97 && c <= 122))
                {
                    list.Add(c);
                }
            }
            var mid = list.Count / 2;
            for (var i = 0; i < mid; i++)
            {
                if (list[i] != list[list.Count - i - 1])
                    return false;
            }
            return true;
        }
    }
}
