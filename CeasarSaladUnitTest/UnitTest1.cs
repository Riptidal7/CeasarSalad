namespace CeasarSaladUnitTest;

using CeasarSalad;

public class UnitTest1
{
    [Theory]
    [InlineData("Hello", 3, "Khoor")]
    [InlineData("Hello", -3, "Ebiil")]
    [InlineData("Xyz", 3, "Abc")]
    public void Test1(string input, int shift, string encoded)
    {
        Assert.Equal(encoded, CeasarCipher.Encode(input, shift));
    }
}