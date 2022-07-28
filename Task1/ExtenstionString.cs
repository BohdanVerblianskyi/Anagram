using System.Text;

namespace Task1;

public static class ExtenstionString
{
    public static string Reverse(this string text)
    {
        if (text == null)
            throw new ArgumentNullException(nameof(text));

        StringBuilder cash = new StringBuilder();
        StringBuilder result = new StringBuilder(text.Length);
        
        foreach (char ch in text)
        {
            cash.Append(ch);

            if (Char.IsSeparator(ch))
            {
                result.Append(ReverseWord(cash.ToString()));
                cash.Clear();
            }
        }

        result.Append(ReverseWord(cash.ToString()));

        return result.ToString();
    }

    public static  string ReverseWord(this string word)
    {
        if (word == null)
            throw new ArgumentNullException(nameof(word));

        char[] wordChars = word.ToCharArray();

        for (int i = 0, j = wordChars.Length - 1; i < j; i++, j--)
        {
            while (!Char.IsLetter(wordChars[i]))
            {
                if (i > j)
                    return new string(wordChars);

                i++;

                if (OutOfBounds(i, wordChars))
                    return new string(wordChars);
            }

            while (!Char.IsLetter(wordChars[j]))
            {
                if (i > j)
                    return new string(wordChars);

                j--;
                
                if (OutOfBounds(j, wordChars))
                    return new string(wordChars);
            }

            if (Char.IsLetter(wordChars[i]) && Char.IsLetter(wordChars[j]))
                (wordChars[i], wordChars[j]) = (wordChars[j], wordChars[i]);
        }

        return new string(wordChars);
    }

    private static bool OutOfBounds(int index, char[] array) => 
        index >= array.Length;
}