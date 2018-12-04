using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace lianxi
{
    //给定一个非空整数数组，除了某个元素只出现一次以外，其余每个元素均出现两次。找出那个只出现了一次的元素。
    //说明：
    //你的算法应该具有线性时间复杂度。 你可以不使用额外空间来实现吗？
    //示例 1:
    //输入: [2,2,1]
    //输出: 1
    //示例 2:
    //输入: [4,1,2,1,2]
    //输出: 4


    #region 思路
    // 采用位异或 因为一定存在两个着必定为0，只会留下一个未被异或取0的一个数
    #endregion

    class Program
    {
        static void Main(string[] args)
        {

        }
        public class Solution
        {
            public int SingleNumber(int[] nums)
            {
                int sum = 0;
                for (int i = 0; i < nums.Length; i++)
                    sum = sum ^ nums[i];

                return sum;
            }
        }





    }
}
