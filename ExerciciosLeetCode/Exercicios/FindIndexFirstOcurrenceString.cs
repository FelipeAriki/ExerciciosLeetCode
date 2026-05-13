namespace ExerciciosLeetCode.Exercicios;

public class FindIndexFirstOcurrenceString
{
    public void Executar()
    {
        string haystack = "butbutsad";
        string needle = "sad";

        int firstIndex = StrStr(haystack, needle);
        Console.WriteLine(firstIndex);
    }

    public int StrStr(string haystack, string needle)
    {
        // Percorre a string principal
        for (int i = 0; i <= haystack.Length - needle.Length; i++)
        {
            int j = 0;

            // Compara caractere por caractere
            while (j < needle.Length && haystack[i + j] == needle[j])
            {
                j++;
            }

            // Se percorreu toda a needle,
            // encontrou a ocorrência
            if (j == needle.Length)
            {
                return i;
            }
        }

        // Não encontrou
        return -1;
    }
}

/*
28. Find the Index of the First Occurrence in a String

Given two strings needle and haystack, return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.

Example 1:

Input: haystack = "sadbutsad", needle = "sad"
Output: 0
Explanation: "sad" occurs at index 0 and 6.
The first occurrence is at index 0, so we return 0.
Example 2:

Input: haystack = "leetcode", needle = "leeto"
Output: -1
Explanation: "leeto" did not occur in "leetcode", so we return -1.
 

Constraints:

1 <= haystack.length, needle.length <= 104
haystack and needle consist of only lowercase English characters.
 */
