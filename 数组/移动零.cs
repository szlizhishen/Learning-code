using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace lianxi
{
    //    给定一个数组 nums，编写一个函数将所有 0 移动到数组的末尾，同时保持非零元素的相对顺序。
    //示例:
    //输入: [0,1,0,3,12]
    //    输出: [1,3,12,0,0]
    //    说明:
    //必须在原数组上操作，不能拷贝额外的数组。
    //尽量减少操作次数。

    #region 思路
    // 找到零的个数 不是零的数则往前挪 当前零的个数 位 后面自然为0； 

    #endregion

    class Program
    {
        static void Main(string[] args)
        {

        }
        public class Solution
        {
            public void MoveZeroes(int[] nums)
            {

                int zeroNum = 0;//用来计算0的个数

                for (int i = 0; i < nums.Length; i++)
                {

                    if (nums[i] == 0)
                    {//如果nums[i]=0,zeroNum个数加一

                        zeroNum++;

                    }
                    else if (zeroNum != 0)
                    {//如果nums[i]不等于0,将nums[i]跟前zeroNum个交换，并且将nums[i]赋值为0

                        nums[i - zeroNum] = nums[i];

                        nums[i] = 0;

                    }

                }









            }

        }
    }
}
