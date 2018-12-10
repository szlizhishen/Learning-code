using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.IO;
class Test
{
///报数序列是一个整数序列，按照其中的整数的顺序进行报数，得到下一个数。其前五项如下：
//1.     1
//2.     11
//3.     21
//4.     1211
//5.     111221
//1 被读作  "one 1"  ("一个一") , 即 11。
//11 被读作 "two 1s" ("两个一"）, 即 21。
//21 被读作 "one 2",  "one 1" （"一个二" ,  "一个一") , 即 1211。
//给定一个正整数 n（1 ≤ n ≤ 30），输出报数序列的第 n 项。
//注意：整数顺序将表示为一个字符串。
 
    #region 思路
        //  新建记录重复次数的数 并修改 然后遍历一遍，出现数组越界的情况 我给尾巴多增加一个哨兵来避免 输出时再删除即可
    #endregion



    static void Main()
    { 
    }
    public class Solution
    {
        public string CountAndSay(int n)
        {
            string a = "1*", temp = "";
            for (int i = 1; i < n; i++)
            {
                int t = 0;
                while (t < a.Length - 1)
                {
                    int value = 1;
                    while (a[t] == a[t + 1])//&&t+1<a.size()
                    {
                        value++;
                        t++;
                    }
                    temp = temp + value.ToString() + a[t];//char可以直接，不用to_string
                    t++;
                }
                a = temp + "*";
                temp = "";

            }
            return a.Remove(a.Length - 1);
        }

    }

}
