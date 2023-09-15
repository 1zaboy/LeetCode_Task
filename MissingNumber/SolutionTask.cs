namespace MissingNumber
{
    public class SolutionTask
    {
        // Runtime 103 ms Beats 47.40%
        // Memory 44.2 MB Beats 24.36%
        public int MissingNumber(int[] nums)
        {
            if (nums.Length == 0) return 0;

            Array.Sort(nums);

            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != i)
                {
                    return i;

                }
            }

            return nums.Last() + 1;
        }

        // Runtime 88 ms Beats 93.27%
        // Memory 43.9 MB Beats 81.12%
        public int MissingNumber2(int[] nums)
        {
            return nums.Length * (nums.Length + 1) / 2 - nums.Sum();
        }
    }
}