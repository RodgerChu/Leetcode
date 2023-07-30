namespace LeetCode.MinimumSizeSubarraySum;

public static class MinimumSizeSubArraySumSolution
{
    public static int MinSubArrayLen(int target, int[] nums)
    {
        var start = 0;
        var end = 0;
        var minCount = int.MaxValue;
        var sum = nums[0];
        while (end < nums.Length && start < nums.Length)
        {
            if (sum < target)
            {
                if (++end < nums.Length)
                {
                    sum += nums[end];
                }
            }
            else
            {
                minCount = Math.Min(minCount, end - start + 1);
                sum -= nums[start];
                start += 1;
            }
        }

        return minCount == int.MaxValue ? 0 : minCount;
    }
}