using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
class Test
{

///给定两个字符串 s 和 t ，编写一个函数来判断 t 是否是 s 的一个字母异位词。
//示例 1:
//输入: s = "anagram", t = "nagaram"
//输出: true
//示例 2:
//输入: s = "rat", t = "car"
//输出: false
//说明:
//你可以假设字符串只包含小写字母。
//进阶:
//如果输入字符串包含 unicode 字符怎么办？你能否调整你的解法来应对这种情况？


    #region 思路
        // 哈希表 将一个字符串做增量放入哈希表 另一个字符串做减量除去哈希表的值，
    #endregion



    static void Main()
    {
        Console.Write(" ");
        Console.ReadKey();
    }
    public class Solution
    {
        public bool IsAnagram(string s, string t)
        {
            Dictionary<char, int> dic = new <char, int>(47);
            char[] c1 = s.ToCharArray();
            char[] c2 = t.ToCharArray();
            for (int i = 0; i < c1.Length; i++)
            {
                if (dic.ContainsKey(c1[i]))
                    dic[c1[i]]++;
                else
                    dic.Add(c1[i], 1);
            }
            for (int i = 0; i < c2.Length; i++)
            {
                if (dic.ContainsKey(c2[i]))
                    dic[c2[i]]--;
                else
                    dic.Add(c2[i], 1);
            }
            if (dic.ContainsValue(1))
                return false;
            if (dic.ContainsValue(2))
                return false;
            if (dic.ContainsValue(3))
                return false;
            if (dic.ContainsValue(4))
                return false;

            return true;
        }
    }
}
