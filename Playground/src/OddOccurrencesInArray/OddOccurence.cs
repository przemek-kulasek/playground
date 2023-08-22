namespace OddOccurrencesInArray;

public static class OddOccurence
{
    public static int Count(int[] A)
    {
        /*
         * The solution you provided, using FirstOrDefault with a nested Count operation,
         * has a time complexity of O(n^2), which is not efficient for larger arrays.
         * You can improve the performance by using a more efficient approach.
         * A more performant solution can be achieved using XOR bitwise operation.
         * The basic idea is that XOR of two same numbers results in 0, and XOR of a number with 0 results in the number itself. So, if you XOR all the elements in the array, the result will be the odd occurring element.
         */
        var result = 0;
        
        foreach (var num in A) {
            result ^= num;
        }
        
        return result;
    }
}