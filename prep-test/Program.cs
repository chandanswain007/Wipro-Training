using System;
using System.Collections.Generic;
using System.Linq; // Keep this for .Where() and .Select()

public class Program
{
    public static void Main(string[] args)
    {
        //Input 1: Main String
        string mainString = GetInput("Enter the main string: ");

        //Input 2: Sub String
        string substring = GetInput("Enter the substring to check: ");

        // Input 3: Character to be replaced
        // CORRECTED: Removed redundant GetInput("") call.
        char charToReplace = ' '; // Initialize with a default value
        string charToReplaceInput = GetInput("Enter the character to replace: ");
        if (!string.IsNullOrEmpty(charToReplaceInput))
        {
            charToReplace = charToReplaceInput[0];
        }

        // Input 4: Character to be replaced with
        // CORRECTED: Removed redundant GetInput("") call.
        char replacementChar = ' '; // Initialize with a default value
        string replacementCharInput = GetInput("Enter the replacement character: ");
        if (!string.IsNullOrEmpty(replacementCharInput))
        {
            replacementChar = replacementCharInput[0];
        }

        bool substringExists = CheckSubstringExists(mainString, substring);
        string replacedString = ReplaceCharacter(mainString, charToReplace, replacementChar);
        string caseSwapped = SwapCase(mainString);
        string noSpaces = RemoveWhitespace(mainString);
        Dictionary<char, int> letterCount = CountLetters(mainString);

        Console.WriteLine($"Substring Exists: {(substringExists ? "Yes" : "No")}");
        Console.WriteLine($"Replaced: {replacedString}");
        Console.WriteLine($"Case Swapped: {caseSwapped}");
        Console.WriteLine($"No Spaces: {noSpaces}");
        // CORRECTED: Removed .OrderBy() to match the specific order in your Expected Output
        Console.WriteLine($"Letter Count: {string.Join(", ", letterCount.Select(kvp => $"{kvp.Key}: {kvp.Value}"))}");
    }

    static string GetInput(string prompt)
    {
        // CORRECTED: Changed WriteLine to Write so input appears on the same line as prompt
        Console.Write(prompt);
        return Console.ReadLine();
    }

    static bool CheckSubstringExists(string main, string sub)
    {
        // Write your code below
        return main.Contains(sub);
    }

    static string ReplaceCharacter(string input, char oldChar, char newChar)
    {
        // write your code below
        return input.Replace(oldChar, newChar);
    }

    static string SwapCase(string input)
    {
        // Write your code below
        char[] chars = input.ToCharArray();
        for (int i = 0; i < chars.Length; i++)
        {
            if (char.IsUpper(chars[i]))
            {
                // CORRECTED: Use 'chars' array variable name
                chars[i] = char.ToLower(chars[i]);
            }
            else if (char.IsLower(chars[i]))
            {
                chars[i] = char.ToUpper(chars[i]);
            }
            // Non-alphabetic characters are implicitly unchanged
        }
        return new string(chars);
    }

    static string RemoveWhitespace(string input)
    {
        // Write your code below
        return new string(input.Where(c => !char.IsWhiteSpace(c)).ToArray());
    }

    static Dictionary<char, int> CountLetters(string input)
    {
        // Write your code below
        // CORRECTED: Ensure consistent variable name 'letterCount'
        Dictionary<char, int> letterCount = new Dictionary<char, int>();
        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                char lowerChar = char.ToLower(c);
                if (letterCount.ContainsKey(lowerChar))
                {
                    letterCount[lowerChar]++;
                }
                else
                {
                    letterCount.Add(lowerChar, 1);
                }
            }
        }
        return letterCount;
    }
}