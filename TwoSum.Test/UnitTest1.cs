namespace TwoSum.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            SolutionTask solutionTask = new SolutionTask();

            var data = new[] { 2, 7, 11, 15 };
            var target = 13;
            var value = solutionTask.TwoSum(data, target);

            Assert.Equal(new[] { 0, 2 }, value);
        }

        [Fact]
        public void Test2()
        {
            SolutionTask solutionTask = new SolutionTask();

            var data = new[] { 3, 2, 4 };
            var target = 6;
            var value = solutionTask.TwoSum(data, target);

            Assert.Equal(new[] { 1, 2 }, value);
        }

        [Fact]
        public void Test3()
        {
            SolutionTask solutionTask = new SolutionTask();

            var data = new[] { 3, 3 };
            var target = 6;
            var value = solutionTask.TwoSum(data, target);

            Assert.Equal(new[] { 0, 1 }, value);
        }
    }
}