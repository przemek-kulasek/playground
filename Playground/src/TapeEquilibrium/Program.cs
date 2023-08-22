//A non-empty array A consisting of N integers is given. Array A represents numbers on a tape.
//It is the absolute difference between the sum of the first part and the sum of the second part

using TapeEquilibrium;

var testData = new int[] { 3, 1, 2, 4, 3 };
var result = TapeCalculator.Calculate(testData);
Console.WriteLine($"The result is {result}");