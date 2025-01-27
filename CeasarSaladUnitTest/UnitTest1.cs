namespace CeasarSaladUnitTest;

public class UnitTest1
{
    [Theory]
    [InlineData("Hello", 2, "Jgnnq")]
    public void Test1(string input, int shift, string encoded)
    {
        Assert.Equal(encoded, (CeasarCipher.Encode(input, shift);
    }
}