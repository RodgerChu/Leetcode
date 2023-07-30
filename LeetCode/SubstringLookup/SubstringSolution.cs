namespace LeetCode.SubstringLookup;

public static class SubstringSolution
{
    // very memory efficient solution
    // 
    public static int FindSubstringIndex(string haystack, string needle)
    {
        if (haystack.Length < needle.Length)
        {
            return -1;
        }

        if (haystack.Length == needle.Length)
        {
            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] != needle[i])
                {
                    return -1;
                }
            }

            return 0;
        }

        for (int i = 0; i < haystack.Length - needle.Length + 1; i++)
        {
            
            for (int j = 0; j < needle.Length; j++)
            {
                if (haystack[i + j] != needle[j])
                {
                    goto NextCharAtHaystack;
                }
            }

            return i;
            
            NextCharAtHaystack: ;
        }

        return -1;
    }
}