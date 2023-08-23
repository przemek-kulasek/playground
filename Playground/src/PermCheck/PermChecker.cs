namespace PermCheck;

public static class PermChecker
{
    public static int Check(int[] A)
    {
        var seen = new int[A.Length];

        for (var i = 0; i < A.Length; i++)
        {
            if (A[i] < 1 || A[i] > A.Length)
            {
                //out of range
                return 0;
            }
            else if (seen[A[i]-1] == 1)
            {
                //met before
                return 0;
            }
            else
            {
                //found first time
                seen[A[i]-1] = 1;
            }
        }
        return 1;
    }
}