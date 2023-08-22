//An array A consisting of N different integers is given.
//The array contains integers in the range [1..(N + 1)], which means that exactly one element is missing.

using PermMissingElem;
var testData = new int [] { 2, 3, 1, 5};
var result = MissingElementFinder.Find(testData);
Console.WriteLine($"The missing element is {result}");