namespace MaxCounters;

public static class Counters
{
    public static int[] Calculate(int N, int[] A)
    {
        var counters = new int[N];
        var maxCounter = 0;
        var lastMaxCounterUpdate = 0;
        
        foreach (var value in A)
        {
            if (value >= 1 && value <= N)
            {
                var index = value - 1;
                if (counters[index] < lastMaxCounterUpdate)
                {
                    counters[index] = lastMaxCounterUpdate + 1;
                }
                else
                {
                    counters[index]++;
                }
                
                if (counters[index] > maxCounter)
                {
                    maxCounter = counters[index];
                }
            }
            else if (value == N + 1)
            {
                lastMaxCounterUpdate = maxCounter;
            }
        }
        
        for (var i = 0; i < N; i++)
        {
            if (counters[i] < lastMaxCounterUpdate)
            {
                counters[i] = lastMaxCounterUpdate;
            }
        }

        return counters;
    }
}