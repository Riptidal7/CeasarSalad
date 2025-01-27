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

    //@daisy
    public static string Decode(string message, int shift)
    {
        return (Shift(message, -shift));
    }

    public static string Shift(string message, int shift)
    {
        if (string.IsNullOrEmpty(message)) return message;
        shift = shift % 26;
        char[] result = new char[message.Length];
       
        for (int i = 0; i < message.Length; i++)
        {
            char c = message[i];
            if(char.IsLetter(c))
            {
                char offset = char.IsUpper(c) ? 'A' : 'a';
                result[i] = (char)(((c - offset + shift + 26) % 26) + offset);
            }
            else
            {
                result[i] = c;
            }
        }
        return new string(result);
    }
}