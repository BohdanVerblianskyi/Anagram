using Task1;

namespace AnagramUnitTest;

public class ExtenstionStringUnitTest
{
    [Theory]
    [InlineData("a1bcd efg!h", "d1cba hgf!e")]
    [InlineData("a1bcd  efg!h", "d1cba  hgf!e")]
    [InlineData("!2#4%6", "!2#4%6")]
    public void ReverseTest(string expected, string input) =>
        Assert.Equal(expected, input.Reverse());

    [Theory]
    [InlineData("tseT", "Test")]
    [InlineData("d1cba", "a1bcd")]
    [InlineData("!2#4%6", "!2#4%6")]
    public void ReverseWordTest(string expected, string input) =>
        Assert.Equal(expected, input.ReverseWord());

    [Fact]
    public void ReverseTestExceptions()
    {
        string input = null;
        Assert.Throws<ArgumentNullException>(() => input.Reverse());
    }

    [Fact]
    public void ReverseWordTestExceptions()
    {
        string input = null;
        Assert.Throws<ArgumentNullException>(() => input.ReverseWord());
    }
}