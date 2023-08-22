//A binary gap within a positive integer N is any maximal sequence of consecutive zeros that is surrounded by ones at both ends in the binary representation of N.

using BinaryGap;

Console.WriteLine("Give us number, please:");
var userInput = Console.ReadLine();
var n = Convert.ToInt32(userInput);
var binaryGap = BinaryGapCalculator.Calculate(n);

Console.WriteLine($"Binary gap for {userInput} is {binaryGap}");
