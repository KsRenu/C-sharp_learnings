int first = 2;
string second = "4";
string result = first + second;
Console.WriteLine(result);


int myInt = 3;
Console.WriteLine($"int: {myInt}");
decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}");



decimal myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");
int myInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}");


decimal myDecimal = 1.23456789m;
float myFloat = (float)myDecimal;
Console.WriteLine($"Decimal: {myDecimal}");
Console.WriteLine($"Float: {myFloat}");


int first = 5;
int second = 7;
string message = first.ToString() + second.ToString();
Console.WriteLine(message);



string first = "5";
string second = "7";
int sum = int.Parse(first) + int.Parse(second);
Console.WriteLine(sum);


string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result);


int value = (int)1.5m; // casting truncates
Console.WriteLine(value);
int value2 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value2);



string value = "102";
int result = 0;
if (int.TryParse(value, out result))
{
    Console.WriteLine($"Measurement: {result}");
}
else
{
    Console.WriteLine("Unable to report the measurement.");
}


string value = "102";
int result = 0;
if (int.TryParse(value, out result))
{
    Console.WriteLine($"Measurement: {result}");
}
else
{
    Console.WriteLine("Unable to report the measurement.");
}

// Since it is defined outside of the if statement, 
// it can be accessed later in your code.
Console.WriteLine($"Measurement (w/ offset): {50 + result}");




string value = "bad";
int result = 0;
if (int.TryParse(value, out result))
{
    Console.WriteLine($"Measurement: {result}");
}
else
{
    Console.WriteLine("Unable to report the measurement.");
}

// Since it is defined outside of the if statement, 
// it can be accessed later in your code.
if (result > 0)
    Console.WriteLine($"Measurement (w/ offset): {50 + result}");




//Challenge

// Add all the code necessary to implement the following business rules:
// Business Rules:
// Rule 1: If the value is alphanumeric, concatenate it to form a message
// Rule 2: If the value is numeric, add it to the total
// Rule 3: Make sure the result matches the following output:
// Output

// Copy
// Message: ABCDEF
// Total: 68.3
// Whether you get stuck and need to peek at the solution or you finish successfully, continue to view a solution to this challenge.


string[] values = { "12.3", "45", "ABC", "11", "DEF" };

decimal total = 0m;
string message = "";

foreach (var value in values)
{
    decimal number;
    if (decimal.TryParse(value, out number))
    {
        total += number;
    } else
    {
        message += value;
    }
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");



int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

int result1 = Convert.ToInt32((decimal)value1 / value2);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

float result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");


//Sort() and Reverse()



