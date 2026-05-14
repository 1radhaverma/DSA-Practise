//Given an integer n, return an array ans of length n + 1 
//	such that for each i (0 <= i <= n), ans[i] is the 
//	number of 1's in the binary representation of i.

//Example :
//Input: n = 5
//Output: [0, 1, 1, 2, 1, 2]
//Explanation:
//0-- > 0
//1-- > 1
//2-- > 10
//3-- > 11
//4-- > 100
//5-- > 101

public class Solutions
{
	public int[] CountingBits(int n)
	{
		int[] bits = new int[n + 1];

		for (int i = 0; i < n; i++)
		{
			bits[i] = bits[i >> 1] + (i & 1);
		}
		return bits;

	}
	public static void main(string args[])
	{
		Solutions s = new Solutions();
		Console.WriteLine(string.Join(", ", s.CountingBits(5)));
	}
