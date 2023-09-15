namespace PathSum.Test
{
    public class UnitTest2
    {
        TreeNode node = null;
        int targetSum = -5;

        public UnitTest2()
        {
            node = new TreeNode(-2,
                null,
                new TreeNode(-3)
                );
        }


        [Fact]
        public void Test1()
        {
            SolutionTask task = new SolutionTask();

            var res = task.HasPathSum(node, targetSum);

            Assert.True(res);
        }
    }
}