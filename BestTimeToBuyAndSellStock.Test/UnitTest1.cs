namespace BestTimeToBuyAndSellStock.Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var solutionTest = new BestTimeToBuyAndSellStock.Solution();

        var data = new List<int> { 7, 1, 5, 3, 6, 4 };

        var value = solutionTest.MaxProfit(data.ToArray());

        Assert.Equal(5, value);
    }

    [Fact]
    public void Test2()
    {
        var solutionTest = new BestTimeToBuyAndSellStock.Solution();

        var data = new List<int> { 1, 2 };

        var value = solutionTest.MaxProfit(data.ToArray());

        Assert.Equal(1, value);
    }
}