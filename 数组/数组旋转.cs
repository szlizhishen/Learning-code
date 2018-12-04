using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace lianxi
{
//给定一个数组，将数组中的元素向右移动 k 个位置，其中 k 是非负数。
//示例 1:
//输入: [1,2,3,4,5,6,7]
//    和 k = 3
//输出: [5,6,7,1,2,3,4]
//    解释:
//向右旋转 1 步: [7,1,2,3,4,5,6]
//    向右旋转 2 步: [6,7,1,2,3,4,5]
//    向右旋转 3 步: [5,6,7,1,2,3,4]
//    示例 2:
//输入: [-1,-100,3,99]
//    和 k = 2
//输出: [3,99,-1,-100]
//    解释: 
//向右旋转 1 步: [99,-1,-100,3]
//    向右旋转 2 步: [3,99,-1,-100]
//    说明:
//尽可能想出更多的解决方案，至少有三种不同的方法可以解决这个问题。
//要求使用空间复杂度为 O(1) 的原地算法。


    #region 思路
        // 数组旋转 将不要变的隔离开再将要变的处理后 再转置就是移动了的效果
    #endregion

    class Program
    {
        static void Main(string[] args)
        {

        }
        private void reverse(int[] nums, int start, int end)
        {
            while (start < end)
            {
                int temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
                start++; end--;
            }
        }
        public void rotate(int[] nums, int k)
        {
            if (nums.Length == 0)
            {
                return;
            }

            k = k % nums.Length;
            reverse(nums, 0, nums.Length - k - 1);
            reverse(nums, nums.Length - k, nums.Length - 1);
            reverse(nums, 0, nums.Length - 1);
        }


    }
}
