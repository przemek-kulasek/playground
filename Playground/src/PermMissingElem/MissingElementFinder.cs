namespace PermMissingElem;

public static class MissingElementFinder
{
    public static int Find(int[] A)
    {
        long n = A.Length + 1;
        long expectedSum = n * (n + 1) / 2;
        long arraySum = 0;
        
        for (var i = 0; i < A.Length; i++)
        {
            arraySum += A[i];
        }
        
        return (int) (expectedSum - arraySum);
    }
}