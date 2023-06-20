
namespace StringCalculator;

public class StringCalculatorTests
{
    [Fact]
    public void EmptyStringReturnsZero()
    {
        var calculator = new StringCalculator();


        var result = calculator.Add("");

        Assert.Equal(0, result);
    }


    [Theory]
    [InlineData("1",1)]
    [InlineData("2,3", 5)]
    [InlineData("2,3,4,5", 14)]
    [InlineData("2\n3\n4\n5", 14)]
    [InlineData("2\n3,4\n5", 14)]
    [InlineData("2,3\n4\n5", 14)]
    [InlineData("2,3\n4,5", 14)]
    public void SingleDigit(string numbers, int expected)
    {
        var calculator = new StringCalculator();

        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
    }
}
