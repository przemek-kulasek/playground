namespace CyclicRotation;

public static class CyclicRotator
{
    public static int[] Rotate(int[] a, int k)
    {
        var length = a.Length;
        var result = new int[length];
        
        for (var i = 0; i < length; i++)
        {
            var index = (i + k) % length;
            result[index] = a[i];
        }

        return result;
    }
}