using MaxCounters;

var A = new int[] { 3, 4, 4, 6 , 1, 4, 4 };

var result = Counters.Calculate(5, A);

Console.WriteLine(string.Join(",", result));