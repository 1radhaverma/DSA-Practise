//KADANE'S ALGORITHM


//Example 1:
//Input:
//nums = [2, 3, 5, -2, 7, -4]
//Output:
//15
//Explanation:
//The subarray from index 0 to index 4 has the largest sum = 15, which is the maximum sum of any contiguous subarray.

class Solution
{
    public int MaxSubArray(int[] nums)
    {
        long maxi = long.MinValue;
        long sum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            if (sum < maxi)
            {
                maxi = sum;
            }
            if (sum < 0)
            {
                sum = 0;
            }

        }


        return (int)maxi; // Return the maximum subarray sum
    }
    class Program
    {
        static void Main()
        {
            List<int> arr = new List<int> { -2, 1, -3, 4, -1, 2, 1, -5, 4 };

            Solution sol = new Solution();

            int maxSum = sol.MaxSubArray(arr);

            Console.WriteLine("The maximum subarray sum is: " + maxSum);
        }
    }

}

//tc = O(n) as we traverse the array once
//sc = O(1) as we use only constant extra space