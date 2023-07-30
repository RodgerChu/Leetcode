namespace LeetCode.ReverseInteger;

public class ReverseIntegerSolution
{
    public static int Reverse(int x)
    {
        if (x == int.MinValue)
        {
            return 0;
        }

        try
        {
            Int32 result = 0;
            var isNegative = false;
            if (x < 0)
            {
                isNegative = true;
                x *= -1;
            }
            do
            {
                var remainder = x % 10;
                var nextResult = result * 10 + remainder;
                if ((nextResult - remainder) / 10 != result)
                {
                    return 0;
                }

                result = nextResult;
                x /= 10;
            } while (x > 0);

            if (isNegative)
            {
                return -result;
            }
            return result;
        }
        catch (Exception)
        {
            return 0;
        }
    }
}