public class Solution
{
    public int GetSum(int a, int b)
    {
        return a + b;
    }
    public static void main(string args[])
    {
        Solution s = new Solution();
        s.GetSum(5, 10);
        Console.WriteLine(s.GetSum(5,10));
    }
}