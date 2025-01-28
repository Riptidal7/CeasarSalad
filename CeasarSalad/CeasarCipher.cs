namespace CeasarSalad;
using System;
using System.Collections.Generic;
using System.Linq;

public class CeasarCipher
{
    public static string Encode(string message, int shift)
    {
        return (Shift(message, +shift));
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
            if (char.IsLetter(c))
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

    
    // Frequencies of letters in the English language (most to least frequent)
    private static readonly string EnglishFrequency = "ETAOINSHRDLCUMWFGYPBVKJXQZ";

    public static string Crack(string cipherText) 
    {
        
        var letterFrequency = CountLetterFrequency(cipherText);
        var sortedFrequency = letterFrequency.OrderByDescending(x => x.Value).ToList();
        char mostFrequentCipherLetter = sortedFrequency.First().Key;
        int shift = (mostFrequentCipherLetter - 'A') - (EnglishFrequency[0] - 'A');
        return Decode(cipherText, shift);
    }

    private static Dictionary<char, int> CountLetterFrequency(string text)
    {
        var frequency = new Dictionary<char, int>();
        foreach (char c in text.ToUpper())
        {
            if (char.IsLetter(c))
            {
                if (frequency.ContainsKey(c))
                    frequency[c]++;
                else
                    frequency[c] = 1;
            }
        }

        return frequency;
    }

}
