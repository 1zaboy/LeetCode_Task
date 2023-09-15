namespace MissingNumber.Test
{
    public class UnitTest2
    {
        [Fact]
        public void Test1()
        {
            SolutionTask task = new SolutionTask();

            
            var data = new List<int> { 3, 0, 1 };
            var value = task.MissingNumber2(data.ToArray());

            Assert.Equal(2, value);
        }

        [Fact]
        public void Test2()
        {
            SolutionTask task = new SolutionTask();

            var data = new List<int> { 0, 1 };
            var value = task.MissingNumber2(data.ToArray());

            Assert.Equal(2, value);
        }
    }
}