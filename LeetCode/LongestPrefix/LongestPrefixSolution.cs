using System.Text;

namespace LeetCode.LongestPrefix;

public static class LongestPrefixSolution
{
    public static string LongestCommonPrefix(string[] strs)
    {
        var firstStr = strs[0];
        
        var ind = 0;
        do
        {
            if (firstStr.Length <= ind)
            {
                goto Return;
            }

            var nextChar = firstStr[ind];
            
            for (var index = 1; index < strs.Length; index++)
            {
                var str = strs[index];
                if (str.Length <= ind)
                {
                    goto Return;
                }

                if (str[ind] != nextChar)
                {
                    goto Return;
                }
            }
            
            ind += 1;
        } while (true);
        
        Return:
        return firstStr.Substring(0, ind);
    }
}