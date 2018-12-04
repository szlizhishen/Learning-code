﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace lianxi
{
    //    给定一个 n × n 的二维矩阵表示一个图像。
    //将图像顺时针旋转 90 度。
    //说明：
    //你必须在原地旋转图像，这意味着你需要直接修改输入的二维矩阵。请不要使用另一个矩阵来旋转图像。
    //示例 1:
    //给定 matrix =
    //[
    //  [1, 2, 3],
    //  [4, 5, 6],
    //  [7, 8, 9]
    //],

    //原地旋转输入矩阵，使其变为:
    //[
    //  [7,4,1],
    //  [8,5,2],
    //  [9,6,3]
    //]
    #region 思路
        // 旋转本质
    #endregion

    class Program
    {
        static void Main(string[] args)
        {

        }
        public class Solution
        {

            public void Rotate(int[,] matrix)
            {

                if (matrix.Length < 2 || matrix == null)
                {
                    return;
                }
                int n = matrix.GetLength(0);
                int s = n / 2;
                for (int i = 0; i < s; i++)
                {
                    for (int j = i; j < n - 1 - i; j++)
                    {
                        int temp = matrix[i, j];
                        matrix[i, j] = matrix[n - j - 1, i];
                        matrix[n - j - 1, i] = matrix[n - 1 - i, n - 1 - j];
                        matrix[n - 1 - i, n - 1 - j] = matrix[j, n - 1 - i];
                        matrix[j, n - 1 - i] = temp;
                    }
                }

            }
        






        }
    }
}
