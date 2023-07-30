namespace LeetCode.PlusOne;

public static class PlusOneSolution
{
    public static int[] PlusOne(int[] digits)
    {
        var transposition = 0;
        digits[^1] += 1;
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            ref var v = ref digits[i];
            v += transposition;
            transposition = 0;
            if (v >= 10)
            {
                transposition = 1;
                v = 0;
            }
        }

        if (transposition != 0)
        {
            var newArr = new int[digits.Length + 1];
            Array.Copy(digits, 0, newArr, 1, digits.Length);
            newArr[0] = transposition;
            return newArr;
        }

        return digits;
    }
}