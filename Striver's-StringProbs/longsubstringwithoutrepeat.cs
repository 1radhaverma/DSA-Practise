//LONGEST SUBSTRING WITHOUT REPEATING CHARACTER
//s = cadbzabcd 
// brute force approach 
for(int i =0; i < s.Length; i++)
{
    string sub = "";
    for (int j =0; j<s.Length; j++)
    {
        sub = sub + s[j];
    }   
}

// every char in this planet strt from 0 ends to 255 in the asci char code whn convert to int
// 1st approach - using hashing 
for (int i = 0; i < s.Length; i++)
{
    hash[256] ={ 0};
    for (int j = 0; j < s.Length; j++)
    {
        if (hash[s[j]] == 1)
        {
            break;
        }
        len j-i - 1;
        maxlen = max(len, maxlen);
        hash[s[j]] = 1;
    }
}


// optimized
//1. note down the indexes of the char of the strings
// 2. use a sliding window approach to find the longest substring without repeating characters
public int LengthOfLongestSubstringwoutrepeat(string s)
{
    int n = s.Length;
    if (n == 0) return 0;

    int[] hash = new int[256];
    Array.Fill(hash, -1); // You must fill the whole array with -1

    int l = 0, r = 0, maxLen = 0;

    while (r < n)
    {
        if (hash[s[r]] != -1)
        {
            // The "Jump" logic - keep l from moving backwards
            l = Math.Max(hash[s[r]] + 1, l);
        }

        maxLen = Math.Max(maxLen, r - l + 1);
        hash[s[r]] = r;
        r++;
    }
    return maxLen;
}
//tc = O(n)
//    SC = O(256)  

