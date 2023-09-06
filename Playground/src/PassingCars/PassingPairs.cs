namespace PassingCars;

public static class PassingPairs
{
    
    public static int Count(int[] A)
    {
        var countEast = 0;
        var passingCount = 0;
        
        foreach (var car in A)
        {
            if (car == 0)
            {
                countEast++;
            }
            else
            {
                passingCount += countEast;
                
                if (passingCount > 1000000000)
                {
                    return -1;
                }
            }
        }

        return passingCount;
    }
}