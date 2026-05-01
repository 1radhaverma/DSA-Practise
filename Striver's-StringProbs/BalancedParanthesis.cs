//balanced Parenthesis - Using Stack 
using System;
using System.Collections.Generic;

class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> st = new Stack<char>();

        foreach (char C in s)
        {
            if (C == '(' || C == '{' || C == '[')
            {
                st.Push(C);
            }
            else
            {
                if (st.Count == 0) return false;

                char ch = st.Peek();
                st.Pop();

                // Check for matching pair
                if ((C == ')' && ch == '(') ||
                    (C == ']' && ch == '[') ||
                    (C == '}' && ch == '{'))
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
        }

        return st.Count == 0; 
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
