using Task1;

namespace AnagramUnitTest;

public class AnagramUnitTest
{
    private readonly Anagram _anagram;

    public AnagramUnitTest()
    {
        _anagram = new Anagram();
    }

    [Theory]
    [InlineData("a1bcd efg!h", "d1cba hgf!e")]
    [InlineData("a1bcd  efg!h", "d1cba  hgf!e")]
    [InlineData("!2#4%6", "!2#4%6")]
    public void ReverseTest(string expected, string input) =>
        Assert.Equal(expected, _anagram.Reverse(input));

    [Theory]
    [InlineData("tseT", "Test")]
    [InlineData("d1cba", "a1bcd")]
    [InlineData("!2#4%6", "!2#4%6")]
    public void ReverseWordTest(string expected, string input) =>
        Assert.Equal(expected, _anagram.ReverseWord(input));

    [Fact]
    public void ReverseTestExceptions() => 
        Assert.Throws<ArgumentNullException>(() => _anagram.Reverse(null));

    [Fact]
    public void ReverseWordTestExceptions() =>
        Assert.Throws<ArgumentNullException>(() => _anagram.ReverseWord(null));
}

