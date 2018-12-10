using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
class Test
{
//    实现strStr()


//实现 strStr() 函数。
//给定一个 haystack 字符串和一个 needle 字符串，在 haystack 字符串中找出 needle 字符串出现的第一个位置(从0开始)。如果不存在，则返回  -1。
//示例 1:
//输入: haystack = "hello", needle = "ll"
//输出: 2
//示例 2:
//输入: haystack = "aaaaa", needle = "bba"
//输出: -1
//说明:
//当 needle 是空字符串时，我们应当返回什么值呢？这是一个在面试中很好的问题。
//对于本题而言，当 needle 是空字符串时我们应当返回 0 。这与C语言的 strstr() 以及 Java的 indexOf() 定义相符。

    #region 思路
        // 逐个匹配即可 可以改进 参考kmp算法 空串 与 null 不同
    #endregion



    static void Main()
    {
        Console.Write(" ");
        Console.ReadKey();
    }
    public class Solution
    {
        public int StrStr(string haystack, string needle)
        {
            var match = true;
            //从首字母循环，后面的部分无需放在外循环     
            //因为内循环可以比较到      
            for (var i = 0; i <= haystack.Length - needle.Length; i++)
            {
                //默认为匹配          
                match = true;
                for (var j = 0; j < needle.Length; j++)
                {
                    //使用内循环逐一判定是否每个字母都能匹配    
                    if (haystack[i + j] != needle[j])
                    {
                        //发现不匹配时立刻退出内循环              
                        match = false;
                        break;
                    }
                }
                //如果全部匹配，则直接返回i     
                if (match) return i;
            }
            //无法完成匹配     
            return -1;

        }
    }
}
