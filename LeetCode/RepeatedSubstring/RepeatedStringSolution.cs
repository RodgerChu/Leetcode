namespace LeetCode.RepeatedSubstring;

public static class RepeatedStringSolution
{
    public static bool RepeatedSubstringPattern(string s) 
    {
        var middleIndex = s.Length / 2;
        for (int i = middleIndex; i > 0; i--)
        {
            if (s.Length % i != 0)
            {
                continue;
            }
            var found = true;
            var subStr = s.AsSpan(0, i);
            for (int j = i; j < s.Length; j++)
            {
                var ind = j % subStr.Length;
                if (s[j] != subStr[ind])
                {
                    found = false;
                    break;
                }
            }

            if (found)
            {
                return true;
            }
        }

        return false;
    }
}