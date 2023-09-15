namespace SingleNumber.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            SolutionTest solutionTest = new SolutionTest();

            var data = new List<int> { 2, 2, 1 };

            var value = solutionTest.SingleNumber(data.ToArray());

            var findingValue = 1;
            Assert.Equal(findingValue, value);
        }
    }
}