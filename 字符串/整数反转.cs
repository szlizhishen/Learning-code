using System;
using System.Text.RegularExpressions;
class Test
{

//    给出一个 32 位的有符号整数，你需要将这个整数中每位上的数字进行反转。
//示例 1:
//输入: 123
//输出: 321
// 示例 2:
//输入: -123
//输出: -321
//示例 3:
//输入: 120
//输出: 21
//注意:
//假设我们的环境只能存储得下 32 位的有符号整数，则其数值范围为[−231, 231 − 1]。请根据这个假设，如果反转后整数溢出那么就返回 0。

    #region 思路
        //将末尾数通过 10取余得到再逐次*10可以反转，注意容量使用 int64装载
    #endregion



    static void Main()
    {
        Console.Write(Solution.Reverse(-123));
        Console.ReadKey();
    }
    public class Solution
    {
        public static int Reverse(int x)
        {
            int temp = 0;
            Int64 sum = 0;
            int xx = 1;
            int tx=x;
            int ten = 10;
            int max = 2147483647;
    
        
            while (tx!=0)
            {
                temp = tx % ten;
                tx = tx / ten;
                sum = sum * ten + temp;
            }
            if (sum > Int32.MaxValue || sum < Int32.MinValue)
            {
                return 0;
            }
            x = xx * (Int32)sum;
            return x;
        }
    }
}
