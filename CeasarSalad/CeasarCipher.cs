namespace CeasarSalad;

public class CeasarCipher
{
    public static string Encode(string message, int shift)
    {
        string result = "";
        foreach (char c in message)
        {
            char shifted = (char)(c + shift);
            result += shifted;
        }
        return result;
    }

    public static string Decode(string message, int shift)
    {
        string result = "";
        return result;
    }
}