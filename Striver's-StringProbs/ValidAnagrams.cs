using System;

public class Program
{
    static bool IsAnagram(string str1, string str2)
    {
        if (str1.Length != str2.Length) return false;

        int[] charCount = new int[256];

        for (int i = 0; i < str1.Length; i++)
        {
            charCounts[str1[i]]++;
            charCounts[str2[i]]--;
        }

        foreach (int count in charCounts)
        {
            if (count != 0) return false;
        }
        return true;
    }
    static void Main()
    {
        Console.WriteLine(IsAnagramOptimized("INTEGER", "TEGERNI") ? "True" : "False");
    }
}
//tc - O(N)
//SC - O(1)