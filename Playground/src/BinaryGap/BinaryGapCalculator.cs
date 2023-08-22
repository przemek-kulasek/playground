namespace BinaryGap;

public static class BinaryGapCalculator
{
    public static int Calculate(int n)
    {
        var binaryString = Convert.ToString(n, 2);
        var maxGap = 0;
        var currentGap = 0;

        foreach (var digit in binaryString)
        {
            if (digit == '1')
            {
                maxGap = Math.Max(maxGap, currentGap);
                currentGap = 0;
            }
            else
            {
                currentGap++;
            }
        }
        
        return maxGap;
    }
}