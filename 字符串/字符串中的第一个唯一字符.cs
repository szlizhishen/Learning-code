using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
class Test
{

//    给定一个字符串，找到它的第一个不重复的字符，并返回它的索引。如果不存在，则返回 -1。
//案例:
//s = "leetcode"
//返回 0.

//s = "loveleetcode",
//返回 2.
 
//注意事项：您可以假定该字符串只包含小写字母。


    #region 思路
        // 桶排法
    #endregion



    static void Main()
    {
        Console.Write(" ");
        Console.ReadKey();
    }
    public class Solution
    {
        public int FirstUniqChar(string s)
        {
            char [] c= s.ToCharArray();
            int [] a=new  int [30];
            for(int i = 0; i < c.Length; i++)
            {
                a[c[i] - 'a']++;
            }
            for(int i=0; i < c.Length; i++)
            {
                if (a[c[i] - 'a'] == 1)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
