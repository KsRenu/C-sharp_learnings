// See https://aka.ms/new-console-template for more information
//Question: Use a method of the System.Math class to determine which of two numbers is larger.

int val1=500;
int val2=600;
Console.WriteLine( System.Math.Max (val1, val2));

//solution
int firstValue = 500;
int secondValue = 600;
int largerValue;
largerValue = Math.Max(firstValue, secondValue);
Console.WriteLine(largerValue);