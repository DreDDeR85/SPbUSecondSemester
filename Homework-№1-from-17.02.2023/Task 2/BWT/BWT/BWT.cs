using System;
using System.Text;

namespace BWT;
internal class RotationsComparer : IComparer<int>
{
    public RotationsComparer(string str)
    {
        this._string = str;
    }

    private string _string;

    int IComparer<int>.Compare(int firstElement, int secondElement)
    {
        for (int i = 0; i < _string.Length; i++)
        {
            if (_string[(firstElement + i) % _string.Length] > _string[(secondElement + i) % _string.Length])
            {
                return 1;
            }
            else if (_string[(firstElement + i) % _string.Length] < _string[(secondElement + i) % _string.Length])
            {
                return -1;
            }
        }
        return 0;
    }
}

public class BWT
{
    private const int _alphabetSize = 65536;

    public static (string, int) Encode(string text)
    {
        var rotations = new int[text.Length];
        for (int i = 0; i < rotations.Length; ++i)
        {
            rotations[i] = i;
        }

        Array.Sort(rotations, new RotationsComparer(text));

        var result = new StringBuilder();
        int lineEndIndex = 0;
        for (int i = 0; i < text.Length; ++i)
        {
            result.Append(text[(rotations[i] + text.Length - 1) % text.Length]);

            if (rotations[i] == 0)
            {
                lineEndIndex = i;
            }
        }

        return (result.ToString(), lineEndIndex);
    }

    public static string Decode(string text, int lineEndIndex)
    {
        if (text.Length == 0)
        {
            throw new ArgumentNullException("Text to transform cannot be empty.");
        }

        var characterFrequencies = new int[_alphabetSize];
        for (int i = 0; i < text.Length; ++i)
        {
            ++characterFrequencies[text[i]];
        }

        int sum = 0;
        for (int i = 0; i < _alphabetSize; ++i)
        {
            sum += characterFrequencies[i];
            characterFrequencies[i] = sum - characterFrequencies[i];
        }

        var nextSymbolsIndexes = new int[text.Length];
        for (int i = 0; i < text.Length; ++i)
        {
            nextSymbolsIndexes[characterFrequencies[text[i]]] = i;
            ++characterFrequencies[text[i]];
        }

        var nextSymbol = nextSymbolsIndexes[lineEndIndex];
        var result = new StringBuilder();
        for (int i = 0; i < text.Length; ++i)
        {
            result.Append(text[nextSymbol]);
            nextSymbol = nextSymbolsIndexes[nextSymbol];
        }

        return result.ToString();
    }
}