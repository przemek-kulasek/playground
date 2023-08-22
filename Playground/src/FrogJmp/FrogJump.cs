namespace FrogJmp;

public static class FrogJump
{
    public static int Calculate(int X, int Y, int D)
    {
        var distanceNeeded = Y - X;
        var rawValue = (double) distanceNeeded / D;
        var numberOfJumps = (int) Math.Ceiling(rawValue);
        return numberOfJumps;
    }
}