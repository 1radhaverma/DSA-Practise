//Given a positive integer n, write a function that returns the
//number of set bits in its binary representation
//(also known as the Hamming weight).


public class Solution
{
    public int NumberBits(int num)
    {
        int count = 0;
        uint n = (uint)num;
        //The loop ran exactly 3 times
        //because there were exactly 3 one-bits inside the number 13.
        while (num > 0)
        {
            num &= num - 1;
            count++;
        }

    }
    public static void main (String args[])
    {
        Solution s = new Solution();
        s.NumberBits(13);
        Console.WriteLine(s.NumberBits(13));    
    }
}