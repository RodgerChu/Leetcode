namespace LeetCode.IsArithmetic;

public static class IsArithmeticProgressionSolution
{
    public static bool CanMakeArithmeticProgression(int[] arr)
    {
        var span = arr.AsSpan();
        span.Sort();
        var delta = span[1] - span[0];
        for (int i = 2; i < span.Length; i++)
        {
            var d = span[i] - span[i - 1];
            if (d != delta)
            {
                return false;
            }
        }

        return true;
    }
}