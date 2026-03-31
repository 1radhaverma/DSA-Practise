======================================================
//1stapproach : Brute Force

using System;
using System.Collections.Generic;

class Program
{
    // Function to check if array contains any duplicate elements
    static bool ContainsDuplicate(List<int> nums)
    {
        // Iterate through each element
        for (int i = 0; i < nums.Count; i++)
        {
            // Compare with every element ahead of it
            for (int j = i + 1; j < nums.Count; j++)
            {
                // If duplicate found, return true
                if (nums[i] == nums[j])
                {
                    return true;
                }
            }
        }

        // If no duplicates found, return false
        return false;
    }

    static void Main()
    {
        // Sample input array
        List<int> nums = new List<int> { 1, 2, 3, 1 };

        // Call function and store result
        bool res = ContainsDuplicate(nums);

        // Print result
        Console.WriteLine(res ? "true" : "false");
    }
}
//TC-O(n²) due to nested loops
//SC=O(1) as no extra space is used
===================================================================
// 2nd approach : Sorting

using System;
using System.Collections.Generic;

class Program
{
    // Function to check if duplicates exist using sorting
    static bool ContainsDuplicate(List<int> nums)
    {
        // Sort the list
        nums.Sort();

        // Compare adjacent elements
        for (int i = 1; i < nums.Count; i++)
        {
            if (nums[i] == nums[i - 1])
            {
                return true; // Duplicate found
            }
        }

        return false; // No duplicates
    }

    static void Main()
    {
        // Sample input
        List<int> nums = new List<int> { 1, 2, 3, 1 };

        // Call function
        bool res = ContainsDuplicate(nums);

        // Print result
        Console.WriteLine(res ? "true" : "false");
    }
}
//Time Complexity: O(n log n) (due to sorting)
//Space Complexity: O(1) (in-place sort)

====================================================================
//3rd approach : HashSet

using System;
using System.Collections.Generic;

class Program
{
    // Function to check if duplicates exist using HashSet
    static bool ContainsDuplicate(List<int> nums)
    {
        // Create a HashSet to store unique elements
        HashSet<int> set = new HashSet<int>();

        // Insert all elements into the set
        foreach (int num in nums)
        {
            set.Add(num);
        }

        // If duplicates exist, set size < list size
        return set.Count < nums.Count;
    }

    static void Main()
    {
        // Sample input
        List<int> nums = new List<int> { 1, 2, 3, 1 };

        // Check for duplicates
        bool res = ContainsDuplicate(nums);

        // Print result
        Console.WriteLine(res ? "true" : "false");
    }
}
//Time Complexity: O(n)
//Space Complexity: O(n)