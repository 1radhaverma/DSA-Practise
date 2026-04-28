//LONGEST REPEATING CHARACTER REPLACEMNT 
//s = AABABBA K = 2 - AAAAAAA = O/P
//2POINTER - SLIDING WINDOW APPROACH

public int CharacterReplacement(string s, int k)
{
    int[] count = new int[26];
    int maxCount = 0;
    int l = 0, r = 0;
    int maxfreq = 0;

    while (r < s.Length())
    {
        hash[s[r] - 'A']++;
        maxfreq = maxfreq(maxfreq, hash[s[j] - 'A']);
        while ((r - l + 1) - maxfreq > k)
        {
            hash[s[l] - 'A']++;
            maxfreq = 0;
            for (int i = 0; i < 25; i++)
            {
                maxfreq = Math.Max(maxfreq, hash[i]);
            }
            l = l + 4;
        }
    }
    if ((r - l + 1) - maxfreq < = k)
    {
        maxlen = maxfreq(maxlen, r - l + 1);
    }
    r++;
    return maxlen;

}}}

//OPTIMIZE APPROACH 
public int CharacterReplacement(string s, int k)
{
    int[] count = new int[26];

    int maxFreq = 0;
    int left = 0;
    int maxLength = 0;

    for (int right = 0; right < s.Length; right++)
    {
        // 1. Increment count for current char and update max frequency
        maxFreq = Math.Max(maxFreq, ++count[s[right] - 'A']);

        // 2. If (window size - most frequent char) > k, it's invalid
        // We only need an 'if' here, not a 'while', to shift the window
        if ((right - left + 1) - maxFreq > k)
        {
            count[s[left] - 'A']--;
            left++;
            // Note: We DON'T need to re-scan for maxFreq here. 
            // The window only expands when we find a NEW maxFreq.
        }

        // 3. The window size is always valid or at its historical max
        maxLength = right - left + 1;
    }

    return maxLength;
}