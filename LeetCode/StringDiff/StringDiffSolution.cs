namespace LeetCode.StringDiff;

public static class StringDiffSolution
{
    private const char m_firstLetter = 'a';
    private const char m_finalLetter = 'z';
    
    // Slower, but memory efficient. Can remove memory allocation by using the `unsafe stackalloc`
    public static char FindTheDifference(string s, string t)
    {
        if (t.Length == 1)
        {
            return t[0];
        }
        
        var charsCounters = new int['z' - 'a' + 1];
        for (int i = 0; i < s.Length; i++)
        {
            charsCounters[s[i] - 'a'] += 1;
            charsCounters[t[i] - 'a'] -= 1;
        }
        
        charsCounters[t[t.Length - 1] - 'a'] -= 1;

        for (int i = 0; i < charsCounters.Length; i++)
        {
            if (charsCounters[i] < 0)
            {
                return (char)(i + 'a');
            }
        }

        return t[0];
    }

    // Faster, but less memory efficient
    public static char FindTheDifference2(string s, string t)
    {
        if (t.Length == 1)
        {
            return t[0];
        }
        
        var dictionary = new Dictionary<int, int>('z' - 'a' + 1);
        for (int i = 0; i < s.Length; i++)
        {
            var key = s[i] - 'a';
            dictionary.TryGetValue(key, out var prevS);
            dictionary[key] = prevS + 1;
            var key1 = t[i] - 'a';
            dictionary.TryGetValue(key1, out var prevT);
            dictionary[key1] = prevT -  1;
        }

        var kLast = t[^1] - 'a';
        dictionary.TryGetValue(kLast, out var last);
        dictionary[kLast] = last -  1;

        foreach (var pair in dictionary)
        {
            if (pair.Value < 0)
            {
                return (char)(pair.Key + 'a');
            }
        }

        return t[0];
    }

    // no mem alloc but unsafe
    public static unsafe char FindTheDeffirenceUnsafe(string s, string t)
    {
        if (t.Length == 1)
        {
            return t[0];
        }

        var length = 'z' - 'a' + 1;
        var charsCounters = stackalloc int[length];
        for (int i = 0; i < s.Length; i++)
        {
            charsCounters[s[i] - 'a'] += 1;
            charsCounters[t[i] - 'a'] -= 1;
        }
        
        charsCounters[t[t.Length - 1] - 'a'] -= 1;

        for (int i = 0; i < length; i++)
        {
            if (charsCounters[i] < 0)
            {
                return (char)(i + 'a');
            }
        }

        return t[0];
    }
}