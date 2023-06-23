

using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;

namespace Greeter.UnitTests;
public class GreetingTest
{
    [Theory]
    [InlineData("Windom", "Hello, Windom.")]
    [InlineData(null,"Hello, Chief.")]
    public void SingleName(string name, string expected)
    {
        var greeter = new GreetingMaker();

        string greeting = greeter.Greet(name);

        Assert.Equal(expected, greeting);
    }

    [Theory]
    [InlineData(null, "Hello, Chief.")]
    [InlineData("", "Hello, Chief.")]
    public void NullName(string name, string expected)
    {
        var greeter = new GreetingMaker();

        string greeting = greeter.Greet(name);

        Assert.Equal(expected, greeting);
    }

    [Theory]
    [InlineData("BOB", "HELLO, BOB.")]
    [InlineData("JOSH", "HELLO, JOSH.")]
    public void ShoutableName(string name, string expected)
    {
        var greeter = new GreetingMaker();

        string greeting = greeter.Greet(name);

        Assert.Equal(expected, greeting);
    }


    [Theory]
    [InlineData("Bob","Sue", "Hello, Bob and Sue.")]
    [InlineData("Josh","John", "Hello, Josh and John.")]
    public void TwoName(string name, string name2, string expected)
    {
        var greeter = new GreetingMaker();

        string greeting = greeter.Greet(name,name2);

        Assert.Equal(expected, greeting);
    }

    [Theory]
    [InlineData("Cole", "Cooper", "Rosenfield", "Preston", "Milford", "Jeffries", "Hello, Cole, Cooper, Rosenfield, Preston, Milford, and Jeffries.")]
    public void MultipleName(string name, string name2, string name3, string name4, string name5, string name6, string expected)
    {
        var greeter = new GreetingMaker();
        

        string greeting = greeter.Greet(name, name2,name3,name4,name5,name6);
        Assert.Equal(expected, greeting);
    }

    [Theory]
    [InlineData("Bob", "SUE", "Jim", "Hello, Bob, Jim, AND SUE.")]
    public void MixedName(string name, string name2, string name3, string expected)
    {
        var greeter = new GreetingMaker();


        string greeting = greeter.Greet(name, name2, name3);

        Assert.Equal(expected, greeting);
    }


}
