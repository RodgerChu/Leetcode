namespace LeetCode.MoveZeroes;

public class MoveZeroesSolution
{
    public static void MoveZeroes(int[] nums) 
    {
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            var v = nums[i];
            if (v == 0)
            {
                for (int j = i; j < nums.Length - 1; j++)
                {
                    nums[j] = nums[j + 1];
                }

                nums[^1] = v;
            }
        }
    }
}