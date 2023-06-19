
namespace BusinessClock.IntegrationTests;

public class DemoTests
{
    [Fact]
    public void CanAddTwoNumbers()
    {
        //Given
        int a = 10, b = 20, answer;
        //When
        answer = a + b; // Systtem under test
        // Then
        Assert.Equal(30, answer);
    }

    [Theory]
    [InlineData(10, 20,30)]

    public void CanAddAnyTwoNumbers(int a, int b,int expected)
    {
        int answer = a + b;

        Assert.Equal(expected, answer);
    }

}
