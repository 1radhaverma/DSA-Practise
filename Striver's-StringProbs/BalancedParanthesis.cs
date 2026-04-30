//balanced Parenthesis - Using Stack 
using System;
using System.Collections.Generic;

class Solution
{
    // Function to check if the input string has valid parentheses
    public bool IsValid(string s)
    {
        Stack<char> st = new Stack<char>();  // Stack to store opening brackets

        foreach (char it in s)
        {
            if (it == '(' || it == '{' || it == '[')
            {
                st.Push(it);  // Push opening brackets
            }
            else
            {
                if (st.Count == 0) return false;  // No matching opening bracket

                char ch = st.Peek();
                st.Pop();

                // Check for matching pair
                if ((it == ')' && ch == '(') ||
                    (it == ']' && ch == '[') ||
                    (it == '}' && ch == '{'))
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
        }

        return st.Count == 0;  // True if all brackets matched
    }
}

class Program
{
    static void Main()
    {
        Solution sol = new Solution();
        string s = "()[{}()]";

        if (sol.IsValid(s))
            Console.WriteLine("True");
        else
            Console.WriteLine("False");
    }
}
