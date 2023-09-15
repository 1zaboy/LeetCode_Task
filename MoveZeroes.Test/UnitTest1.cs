namespace MoveZeroes.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            SolutionTest solutionTest = new SolutionTest();
            var data = new[] { 0, 1, 0, 3, 12 };
            solutionTest.MoveZeroes(data);

            Assert.Equal(new[] { 1, 3, 12, 0, 0 }, data);

        }
    }
}