namespace Calculator.Tests;

public class AddTests
{
    [Fact]
    public void Add_ShouldReturnSum()
    {
        var calc = new BasicCalculator();
        Assert.Equal(5, calc.Add(2, 3));
    }
}