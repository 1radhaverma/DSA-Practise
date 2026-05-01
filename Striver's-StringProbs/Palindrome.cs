using System;

public class Program
{
    public static bool IsPalindrome(int n)
    {
        if(n < 0 || (n % 10 == 0 && n != 0))
            return false;

        long reversedNum = 0;
        int original = n;

        while (n > 0)
        {
            reversedNum = (reversedNum * 10) + (n % 10);
            n /= 10;
        }

        return original == (int)reversedNum;
    }

    public static void Main()
    {
        int number = 4554;

        if (IsPalindrome(number))
            Console.WriteLine($"{number} is a palindrome.");
        else
            Console.WriteLine($"{number} is not a palindrome.");
    }
}
