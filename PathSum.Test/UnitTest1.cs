namespace PathSum.Test
{
    public class UnitTest1
    {
        TreeNode node = null;
        int targetSum = 22;

        public UnitTest1()
        {
            node = new TreeNode(5,
                new TreeNode(4, new TreeNode(11, new TreeNode(7), new TreeNode(2))),
                new TreeNode(8, new TreeNode(13), new TreeNode(4, null, new TreeNode(1)))
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