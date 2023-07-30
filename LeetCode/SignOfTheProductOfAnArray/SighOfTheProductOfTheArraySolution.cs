namespace LeetCode.SignOfTheProductOfAnArray;

public static class SighOfTheProductOfTheArraySolution
{
    public static int ArraySign(int[] nums)
    {
        var negativeValuesCount = 0;
        foreach (var v in nums)
        {
            if (v == 0)
            {
                return 0;
            }

            if (v < 0)
            {
                negativeValuesCount += 1;
            }
        }

        if (negativeValuesCount == 0 || negativeValuesCount % 2 == 0)
        {
            return 1;
        }

        return -1;
    }
}