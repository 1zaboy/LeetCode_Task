namespace SingleNumber
{
    public class SolutionTest
    {
        // Runtime 95 ms Beats 82.36%
        // Memory 45.6 MB Beats 26.60%
        public int SingleNumber(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();

            foreach (var item in nums)
            {
                if (set.Contains(item))
                {
                    set.Remove(item);
                }
                else
                {
                    set.Add(item);
                }
            }

            return set.First();
        }
    }
}