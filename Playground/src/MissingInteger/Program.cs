using MissingInteger;

var testData = new int[] { 1, 3, 6, 4, 1, 2 };
var result = MissingInt.Find(testData);

Console.WriteLine($"Missing integer is {result}");