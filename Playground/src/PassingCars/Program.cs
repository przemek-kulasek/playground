using PassingCars;

var testData = new int[] { 0, 1, 0, 1, 1 };
var result = PassingPairs.Count(testData);

Console.WriteLine($"Number of passing pairs is {result}");