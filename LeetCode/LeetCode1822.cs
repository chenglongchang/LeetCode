using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class LeetCode1822
    {
        public static int ArraySign(int[] nums)
        {
            bool negativeFlag;
            negativeFlag = false;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    return 0;
                }
                else if (nums[i] < 0)
                {
                    negativeFlag = !negativeFlag;
                }
            }

            return negativeFlag ? -1 : 1;
        }

        public static int Test()
        {
            int[] nums = new int[7] { -1, -2, -3, -4, 3, 2, 1 };

            return ArraySign(nums);
        }
    }
}
