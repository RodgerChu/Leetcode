namespace LeetCode.RomanToInteger;

public static class RomanToIntegerSolution
{
    public static int RomanToInt(string s)
    {
        var result = 0;
        for (int i = 0; i < s.Length; i++)
        {
            var value = RomanCharToInt(s[i]);

            if (i == s.Length - 1)
            {
                result += value;
                break;
            }
            
            var nextValue = RomanCharToInt(s[++i]);

            if (value == nextValue)
            {
                result += value + nextValue;
                continue;
            }
            
            switch (value, nextValue)
            {
                case (1, 5):
                    result += 4;
                    break;
                case (1, 10):
                    result += 9;
                    break;
                case (10, 50):
                    result += 40;
                    break;
                case (10, 100):
                    result += 90;
                    break;
                case (100, 500):
                    result += 400;
                    break;
                case (100, 1000):
                    result += 900;
                    break;
                default:
                    result += value;
                    i -= 1;
                    break;
            }
        }
        
        return result;
    }

    private static int RomanCharToInt(char ch)
    {
        switch (ch)
        {
            case 'M':
                return 1000;
            case 'D':
                return 500;
            case 'C':
                return 100;
            case 'L':
                return 50;
            case 'X':
                return 10;
            case 'V':
                return 5;
            default:
                return 1;
        }
    }
}