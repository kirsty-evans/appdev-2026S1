namespace PalindromeTest;

using Palindrome;

public class UnitTest1
{
    [Fact]
    public void IsPalindomre_Test_ABBA()
    {
        Assert.True(Palindrome.IsPalindrome("abba"));
    }

    [Fact]
    public void IsPalindomre_Test_RACECAR()
    {
        Assert.True(Palindrome.IsPalindrome("racecar"));
    }

    [Fact]
    public void IsPalindomre_Test_EmptyString()
    {
        Assert.True(Palindrome.IsPalindrome(""));
    }

    [Fact]
    public void IsPalindomre_Test_aaBBBBaa()
    {
        Assert.True(Palindrome.IsPalindrome("aaBBBBaa"));
    }

    [Fact]
    public void IsPalindomre_Test_NotPalindrome_1()
    {
        Assert.False(Palindrome.IsPalindrome("dog"));
    }

    [Fact]
    public void IsPalindomre_Test_NotPalindrome_2()
    {
        Assert.False(Palindrome.IsPalindrome("cat"));
    }

    [Fact]
    public void IsPalindomre_Test_NotPalindrome_3()
    {
        Assert.False(Palindrome.IsPalindrome("heavy"));
    }
}
