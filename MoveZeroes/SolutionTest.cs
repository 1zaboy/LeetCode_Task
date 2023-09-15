namespace MoveZeroes
{
    public class SolutionTest
    {
        // Runtime 132 ms Beats 99%
        // Memory 54.2 MB Beats 50.10%
        // TODO: Test span perfomans
        public void MoveZeroes(int[] nums)
        {
            var countNull = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    countNull++;
                    continue;
                }

                if (countNull > 0)
                {
                    nums[i - countNull] = nums[i];
                }
            }

            for (int i = nums.Length - countNull; i < nums.Length; i++)
            {
                nums[i] = 0;
            }
        }
    }
}