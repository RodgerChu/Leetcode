namespace LeetCode.IsMonothonicArray;

public  static class IsMonotonicArraySolution
{
    public static bool IsMonotonic(int[] nums)
    {
        var isMonotoneIncreasing = true;
        var isMonotoneDecreasing = true;

        for (int i = 0; i < nums.Length - 1; i++)
        {
            isMonotoneIncreasing &= nums[i] <= nums[i + 1];
            isMonotoneDecreasing &= nums[i] >= nums[i + 1];
        }
        
        return isMonotoneDecreasing || isMonotoneIncreasing;
    }
}