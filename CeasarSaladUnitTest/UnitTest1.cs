namespace CeasarSaladUnitTest;

using CeasarSalad;

public class UnitTest1
{
    [Theory]
    [InlineData("Hello", 3, "Khoor")]
    [InlineData("Hello", -3, "Ebiil")]
    [InlineData("Xyz", 3, "Abc")]
    [InlineData("Hey there", 3, "Khb wkhuh")]
    [InlineData("     Hey there ", 3, "     Khb wkhuh ")]
    [InlineData("Hello", 100000, "Lipps")]
    [InlineData("Hello 23", 100000, "Lipps 23")]
    [InlineData("", 2, "")]
    public void Test1(string input, int shift, string encoded)
    {
        Assert.Equal(encoded, CeasarCipher.Encode(input, shift));
    }

    [Theory]
    [InlineData("Khoor", 3, "Hello")]
    [InlineData("Ebiil", -3, "Hello")]
    [InlineData("Abc", 3, "Xyz")]
    [InlineData("Khb wkhuh", 3, "Hey there")]
    [InlineData("     Khb wkhuh ", 3, "     Hey there ")]
    [InlineData("Lipps", 100000, "Hello")]
    [InlineData("Lipps 23", 100000, "Hello 23")]
    [InlineData("", 2, "")]
    public void Test2(string input, int shift, string decoded)
    {
        Assert.Equal(decoded, CeasarCipher.Decode(input, shift));
    }

    [Theory]
    [InlineData("Xli ibxirhih evq wepyxmrk kiwxyvi aew eppikih xs fi fewih sr er ergmirx Vsqer", "The extended arm saluting gesture was alleged to be based on an ancient Roman")]

    public void Test3(string input, string cracked)
    {
        Assert.Equal(cracked, CeasarCipher.Crack(input));
    }

}