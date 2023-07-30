namespace LeetCode.FindInRotatedArray;

public static class FindInRotatedArraySolution
{
    public static int Search(int[] nums, int target)
    {
        if (nums.Length == 1)
        {
            return nums[0] == target ? 0 : -1;
        }
        
        var pivot = 0;
        var left = 0;
        var right = nums.Length - 1;
        do
        {
            var middle = (left + right) / 2;
            var middleValue = nums[middle];
            var rightValue = nums[right];
            if (middleValue > rightValue)
            {
                if (middle == left)
                {
                    left -= 1;
                }
                else
                {
                    left = middle;
                }
            }
            else
            {
                if (middle == right)
                {
                    right -= 1;
                }
                else
                {
                    right = middle;
                }
            }
        } while (right - left > 1);

        pivot = nums.Length - right;
        left = 0;
        right = nums.Length - 1;
        do
        {
            var middleIndexRaw = (left + right + 1) / 2;
            var middleIndex = middleIndexRaw + pivot;
            if (middleIndex < 0)
            {
                middleIndex += nums.Length;
            }
            else if (middleIndex > nums.Length - 1)
            {
                middleIndex -= nums.Length;
            }
            
            var middleValue = nums[middleIndex];
            if (middleValue == target)
            {
                return middleIndex;
            }
            
            if (middleValue < target)
            {
                if (middleIndexRaw == left)
                {
                    left -= 1;
                }
                else
                {
                    left = middleIndexRaw;
                }
            }
            else
            {
                if (middleIndexRaw == right)
                {
                    right -= 1;
                }
                else
                {
                    right = middleIndexRaw;
                }
            }
            
        } while (right - left >= 1);

        return nums[right % nums.Length] == target ? right : -1;
    }
}