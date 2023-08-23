// See https://aka.ms/new-console-template for more information

using PermCheck;

var testData = new int[] {4, 1, 3, 2};
var result = PermChecker.Check(testData);
Console.WriteLine($"The result is {result}");