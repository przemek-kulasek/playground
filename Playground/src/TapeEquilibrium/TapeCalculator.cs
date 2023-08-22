namespace TapeEquilibrium;

public static class TapeCalculator
{
    public static int Calculate(int[] A)
    {
        if (A.Length == 2)
        {
            return Math.Abs(A[0] - A[1]);
        }

        var sumLeft = A[0];
        var sumRight = A.Sum() - A[0];
        var minDiff = Math.Abs(sumLeft - sumRight);
        for (var i = 1; i < A.Length - 1; i++)
        {
            sumLeft += A[i];
            sumRight -= A[i];
            if (Math.Abs(sumLeft - sumRight) < minDiff)
            {
                minDiff = Math.Abs(sumLeft - sumRight);
            }
        }
        return minDiff;
    }
}