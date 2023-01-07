// See https://aka.ms/new-console-template for more information

string first = "Hello";
string second = "World";
Console.WriteLine("{1} {0}!", first, second);
Console.WriteLine("{0} {0} {0}!", first, second);

//Composite Formatting?
string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);
Console.WriteLine(result);

//string interpolation?
string first = "Hello";
string second = "World";
Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}!");


//Formatting currency
decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");


//Formatting numbers
decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");
decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N4} units");

//Formatting percentages
decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");

//Suppose we want to print a receipt for the sale of a chemical solvent used in industrial settings. While our scales measure in micrograms, we price each sale in milligrams (a thousandth of a gram). To print the receipt, we would likely need to combine data of different types, including fractional values, currency, and percentages in precise ways.
int invoiceNumber = 1201;
decimal productMeasurement = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"   Measurement: {productMeasurement:N3} mg");
Console.WriteLine($"     Sub Total: {subtotal:C}");
Console.WriteLine($"           Tax: {taxPercentage:P2}");
Console.WriteLine($"     Total Due: {total:C}");

//Format strings by adding whitespace before or after
string input = "Pad this";
Console.WriteLine(input.PadLeft(12));
Console.WriteLine(input.PadLeft(12, '-'));
Console.WriteLine(input.PadRight(12, '-'));

// Suppose we work for a payment-processing company that still supports legacy mainframe systems. Often, those systems require data to be input in specific columns. For example, the Payment ID should be stored in columns 1 through 6, the payee's name in columns 7 through 30, and the Payment Amount in columns 31 through 40. Also, importantly, the Payment Amount should be right-aligned.
// We're asked to build an application that will convert data in our relational database management system to the legacy file format. To ensure that the integration will work correctly, our first step is to confirm the file format by giving the legacy system maintainers a sample of our output. Later, we'll build on this work to send hundreds or thousands of payments to be processed via an ASCII text file.
string paymentId = "769";
string payeeName = "Mr. Stephen Ortega";
string paymentAmount = "$5,000.00";
var formattedLine = paymentId.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmount.PadLeft(10);
Console.WriteLine(formattedLine);


//challenge
// At the beginning of this module, we described the scenario of working for a marketing department of a financial services company. To promote the company's newest investment products, we'll send thousands of personalized letters to our company's existing clients. Our job is to write C# code that will merge personalized information about the customer. The letter will contain information like their existing portfolio, and will compare their current returns to projected returns if they were to invest in using our new products.
// Our writers have decided on the following example marketing copy. Here's the desired output, using fictitious customer account data:

// Dear Mr. Jones,
// As a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return.

// Currently, you own 2,975,000.00 shares at a return of 12.75 %.

// Our new product, Glorious Future offers a return of 13.13 %.  Given your current volume, your potential profit would be ¤63,000,000.00.

// Here's a quick comparison:

// Magic Yield         12.75 %   ¤55,000,000.00      
// Glorious Future     13.13 %   ¤63,000,000.00


string customerName = "Mr. Jones";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

Console.WriteLine($"Dear {customerName},");
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n");
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

comparisonMessage = currentProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

comparisonMessage += "\n";
comparisonMessage += newProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

Console.WriteLine(comparisonMessage);