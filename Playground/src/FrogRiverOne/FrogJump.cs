namespace FrogRiverOne;

public static class FrogJump
{
    public static int Calculate(int X, int[] A)
    {
        var B = new int[X];
        var leaves = 0;
        for (var i = 0; i < A.Length; i++)
        {
            if (B[A[i] - 1] == 0)
            {
                B[A[i] - 1]++;
                leaves++;
                if (leaves == X) return i;
            }
        }
        return -1;
    }
}