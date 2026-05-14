public class Solutions
{
    public int AddMissingNumber(int[] nums)
    {
        int n = nums.Length + 1;
        int sum = nums.Sum();
        long expSum = (long)n * (n + 1) / 2;

        return (int) (expSum - sum);
    }
    public static void main(string[] args)
    {
        int[] arr = { 8, 2, 4, 5, 3, 7, 1 };
        Console.WriteLine(missingNum(arr));

    }
}