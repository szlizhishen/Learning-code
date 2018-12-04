using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace lianxi
{
    //给定一个由整数组成的非空数组所表示的非负整数，在该数的基础上加一。
    //最高位数字存放在数组的首位， 数组中每个元素只存储一个数字。
    //你可以假设除了整数 0 之外，这个整数不会以零开头。
    //示例 1:
    //输入: [1,2,3]
    //输出: [1,2,4]
    //解释: 输入数组表示数字 123。
    //示例 2:
    //输入: [4,3,2,1]
    //输出: [4,3,2,2]
    //解释: 输入数组表示数字 4321。

    #region 思路
    //当后面为9的时候要进位，全部为9要加多一位。分别判断即可

    #endregion

    class Program
    {
        static void Main(string[] args)
        {

        }
        public class Solution
        {
            public int[] PlusOne(int[] digits)
            {
                for (int i = digits.Length - 1; i >= 0; i--)
                {
                    if (digits[i] < 9)
                    {
                        digits[i]++;
                        return digits;
                    }
                    digits[i] = 0;
                }
                int[] result = new int[digits.Length + 1];
                for (int i = 1; i < result.Length; i++)
                    result[i] = 0;
                result[0] = 1;
                return result;
            }
        }







    }

}
