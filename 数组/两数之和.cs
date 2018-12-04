using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace lianxi
{
    //给定一个整数数组 nums 和一个目标值 target，请你在该数组中找出和为目标值的 两个 整数。
    //你可以假设每种输入只会对应一个答案。但是，你不能重复利用这个数组中同样的元素。
    //示例:
    //给定 nums = [2, 7, 11, 15], target = 9

    //因为 nums[0] + nums[1] = 2 + 7 = 9
    //所以返回[0, 1]
    #region 思路
       // 求出目标与数的差值 并查表是否存在

    #endregion

    class Program
    {
        static void Main(string[] args)
        {

        }
        public class Solution
        {
            public int[] TwoSum(int[] nums, int target)
            {
                int[] result = new int[2];
                System.Collections.Hashtable table = new System.Collections.Hashtable(nums.Length);  // use empty constructor, result: 544 ms
                for (int i = 0; i < nums.Length; i++)
                {
                    int another = target - nums[i];
                    if (table.ContainsKey(another))
                    {
                        int anotherIndex = (int)table[another];
                        result[0] = anotherIndex > i ? i : anotherIndex;
                        result[1] = anotherIndex < i ? i : anotherIndex;
                        return result;
                    }
                    else
                    {
                        if (!table.Contains(nums[i])) table.Add(nums[i], i);
                    }
                }

                throw new Exception("no answer");

            }











        }
    }
}
