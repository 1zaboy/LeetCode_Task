namespace TrappingRainWater.Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var solutionTest = new TrappingRainWater.Solution();

        var data = new List<int> { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };

        var value = solutionTest.Trap(data.ToArray());

        Assert.Equal(6, value);
    }

    [Fact]
    public void Test2()
    {
        var solutionTest = new TrappingRainWater.Solution();

        var data = new List<int> { 4, 2, 0, 3, 2, 5 };

        var value = solutionTest.Trap(data.ToArray());

        Assert.Equal(9, value);
    }
}