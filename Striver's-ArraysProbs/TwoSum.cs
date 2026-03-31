//Example of TWO SUM PROB.
//Input: N = 5, arr[] = {2,6,5,8,11}, target = 14
//Output : YES
//Explanation: arr[1] + arr[3] = 14. So, the answer is “YES” for first variant for second variant output will be : [1,3].

//Input: N = 5, arr[] = {2,6,5,8,11}, target = 15
//Output : NO.
//Explanation: There exist no such two numbers whose sum is equal to the target. Input: N = 5, arr[] = {2,6,5,8,11}, target = 14
//Output : YES
//Explanation: arr[1] + arr[3] = 14. So, the answer is “YES” for first variant for second variant output will be : [1,3].

//Input: N = 5, arr[] = {2,6,5,8,11}, target = 15
//Output : NO.
//Explanation: There exist no such two numbers whose sum is equal to the target. 

//brute force approach 
using System;
using System.Collections.Generic;


class Solution
{
    // Function to check if any two numbers sum up to target (variant 1)
    public string TwoSumExists(List<int> arr, int target)
    {
        int n = arr.Count;

        // Outer loop picks one element
        for (int i = 0; i < n; i++)
        {
            // Inner loop checks remaining elements
            for (int j = i + 1; j < n; j++)
            {
                if (arr[i] + arr[j] == target)
                {
                    return "YES";
                }
            }
        }

        return "NO";
    }

    // Function to return indices of two numbers that sum to target (variant 2)
    public int[] TwoSumIndices(List<int> arr, int target)
    {
        int n = arr.Count;

        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (arr[i] + arr[j] == target)
                {
                    return new int[] { i, j };
                }
            }
        }

        return new int[] { -1, -1 };
    }
}

class Program
{
    static void Main()
    {
        Solution sol = new Solution();

        List<int> arr = new List<int> { 2, 6, 5, 8, 11 };
        int target = 14;

        // Variant 1
        Console.WriteLine(sol.TwoSumExists(arr, target));

        // Variant 2
        int[] res = sol.TwoSumIndices(arr, target);
        Console.WriteLine($"[{res[0]}, {res[1]}]");
    }
}
///tc = o(n^2) sc = o(1)
//====================================================================
using System;
using System.Collections.Generic;

class Solution
{
    // Variant 1: Check if two numbers sum to target using hashing
    public string TwoSumExists(List<int> arr, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < arr.Count; i++)
        {
            int complement = target - arr[i];

            // Check if complement exists
            if (map.ContainsKey(complement))
            {
                return "YES";
            }

            // Store current element and index
            map[arr[i]] = i;
        }

        return "NO";
    }

    // Variant 2: Return indices of two numbers that sum to target
    public int[] TwoSumIndices(List<int> arr, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < arr.Count; i++)
        {
            int complement = target - arr[i];

            if (map.ContainsKey(complement))
            {
                return new int[] { map[complement], i };
            }

            map[arr[i]] = i;
        }

        return new int[] { -1, -1 };
    }
}

class Program
{
    static void Main()
    {
        Solution sol = new Solution();

        List<int> arr = new List<int> { 2, 6, 5, 8, 11 };
        int target = 14;

        Console.WriteLine(sol.TwoSumExists(arr, target));

        int[] res = sol.TwoSumIndices(arr, target);
        Console.WriteLine($"[{res[0]}, {res[1]}]");
    }
}
//tc = o(n) sc = o(n)
//============================================================================
using System;
using System.Collections.Generic;

class Solution
{
    // Variant 1: Check if two numbers sum to target using two-pointer
    public string TwoSumExists(List<int> arr, int target)
    {
        int n = arr.Count;

        // Store value and original index
        List<(int value, int index)> numsWithIndex = new List<(int, int)>();

        for (int i = 0; i < n; i++)
        {
            numsWithIndex.Add((arr[i], i));
        }

        // Sort based on value
        numsWithIndex.Sort((a, b) => a.value.CompareTo(b.value));

        int left = 0;
        int right = n - 1;

        while (left < right)
        {
            int sum = numsWithIndex[left].value + numsWithIndex[right].value;

            if (sum == target)
            {
                return "YES";
            }
            else if (sum < target)
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return "NO";
    }

    // Variant 2: Return original indices
    public int[] TwoSumIndices(List<int> arr, int target)
    {
        int n = arr.Count;

        List<(int value, int index)> numsWithIndex = new List<(int, int)>();

        for (int i = 0; i < n; i++)
        {
            numsWithIndex.Add((arr[i], i));
        }

        numsWithIndex.Sort((a, b) => a.value.CompareTo(b.value));

        int left = 0;
        int right = n - 1;

        while (left < right)
        {
            int sum = numsWithIndex[left].value + numsWithIndex[right].value;

            if (sum == target)
            {
                return new int[]
                {
                    numsWithIndex[left].index,
                    numsWithIndex[right].index
                };
            }
            else if (sum < target)
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return new int[] { -1, -1 };
    }
}

class Program
{
    static void Main()
    {
        Solution sol = new Solution();

        List<int> arr = new List<int> { 2, 6, 5, 8, 11 };
        int target = 14;

        Console.WriteLine(sol.TwoSumExists(arr, target));

        int[] res = sol.TwoSumIndices(arr, target);
        Console.WriteLine($"[{res[0]}, {res[1]}]");
    } 
}
//tc - O(n log n)  Space Complexity - O(n)
