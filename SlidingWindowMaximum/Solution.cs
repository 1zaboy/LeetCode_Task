using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SlidingWindowMaximum
{
    public class Solution
    {
        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            int n = nums.Length;
            int[] res = new int[n - k + 1];
            int resIndex = 0;

            LinkedList<int> indexList = new LinkedList<int>();

            for (int i = 0; i < n; i++)
            {
                while (indexList.Count > 0 && indexList.First.Value < i - k + 1)
                    indexList.RemoveFirst();

                // если вредыдушая меноньше нынешней
                while (indexList.Count > 0 && nums[indexList.Last.Value] < nums[i])
                    indexList.RemoveLast();

                indexList.AddLast(i);

                if (i >= k - 1)
                    res[resIndex++] = nums[indexList.First.Value];
            }

            return res;
        }
    }
}
