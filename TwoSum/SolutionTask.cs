namespace TwoSum
{
    public class SolutionTask
    {
        // Runtime 144 ms Beats 79.19%
        // Memory 44.3 MB Beats 60.4%
        // TODO: Closures are clearly not the best practice that needs to be redone
        public int[] TwoSum(int[] nums, int target)
        {
            var value = 0;
            int indexFirstItem = 0;
            var indexLastItem = -1;

            int FindIndex()
            {
                for (int i = indexFirstItem + 1; i < nums.Length; i++)
                {
                    if (value == nums[i])
                    {
                        return i;
                    }
                }

                return -1;
            }


            for (indexFirstItem = 0; indexFirstItem < nums.Length - 1; indexFirstItem++)
            {
                value = target - nums[indexFirstItem];
                indexLastItem = FindIndex();

                if (indexLastItem >= 0)
                {
                    return new[] { indexFirstItem, indexLastItem };
                }
            }

            return new int[0];
        }

        // This solution works too but it creates a class for the pridecat
        public int[] TwoSum2(int[] nums, int target)
        {
            var value = 0;
            var startFindPosition = 0;
            int indexFirstItem = 0;
            var indexLastItem = -1;

            for (indexFirstItem = 0; indexFirstItem < nums.Length - 1; indexFirstItem++)
            {
                value = target - nums[indexFirstItem];
                startFindPosition = indexFirstItem + 1;
                indexLastItem = Array.FindIndex(nums, startFindPosition, (x) => x == value);

                if (indexLastItem != -1)
                {
                    return new[] { indexFirstItem, indexLastItem };
                }
            }

            return new int[0];
        }
    }
}