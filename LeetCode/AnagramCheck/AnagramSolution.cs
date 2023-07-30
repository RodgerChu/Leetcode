namespace LeetCode.AnagramCheck;

public static class AnagramSolution
{
    public static bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
        {
            return false;
        }
        
        var charsCounters = new int['z' - 'a' + 1];
        for (int i = 0; i < s.Length; i++)
        {
            charsCounters[s[i] - 'a'] += 1;
            charsCounters[t[i] - 'a'] -= 1;
        }

        for (int i = 0; i < charsCounters.Length; i++)
        {
            if (charsCounters[i] != 0)
            {
                return false;
            }
        }

        return true;
    }
}