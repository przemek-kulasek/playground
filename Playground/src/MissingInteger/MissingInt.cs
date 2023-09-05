namespace MissingInteger;

public static class MissingInt
{
    public static int Find(int[] A)
    {
        var n = A.Length;
        var seen = new bool[n + 1];

        foreach (var num in A)
        {
            if (num > 0 && num <= n)
            {
                seen[num] = true;
            }
        }
        
        for (var i = 1; i <= n; i++)
        {
            if (!seen[i])
            {
                return i;
            }
        }

        return n + 1;
    }
}