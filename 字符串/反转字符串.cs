using System;
using System.Text.RegularExpressions;
class Test
{

    //     编写一个函数，其作用是将输入的字符串反转过来。
    //    示例 1:
    //输入: "hello"
    //输出: "olleh"
    //示例 2:
    //输入: "A man, a plan, a canal: Panama"
    //输出: "amanaP :lanac a ,nalp a ,nam A"

    #region 思路
        //直接调转数组头尾的值就好
    #endregion



    static void Main()
    {
        
    }
    public class Solution
    {
        public string ReverseString(string s)
        {
            char[] b = s.ToCharArray();
            for (int i = 0; i < b.Length / 2; i++)
            {
                char temp = b[i];
                b[i] = b[b.Length - i - 1];
                b[b.Length - i - 1] = temp;
            }
            string c = new string(b);
            return c;
        }
    }
}
