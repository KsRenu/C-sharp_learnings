//sort and reverse
string[] pallets = { "B14", "A11", "B12", "A13" };

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}


//clearing and resizing the array

string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}



string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Console.WriteLine($"Before: {pallets[0]}");
Array.Clear(pallets, 0, 2);
Console.WriteLine($"After: {pallets[0]}");

Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}




string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Console.WriteLine($"Before: {pallets[0].ToLower()}");
Array.Clear(pallets, 0, 2);
Console.WriteLine($"After: {pallets[0].ToLower()}");

Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}



string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}



string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}




//split and join
string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
string result = new string(valueArray);
Console.WriteLine(result);


string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
// string result = new string(valueArray);
string result = String.Join(",", valueArray);
Console.WriteLine(result);


string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
// string result = new string(valueArray);
string result = String.Join(",", valueArray);
Console.WriteLine(result);

string[] items = result.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}



//Challenge
// string pangram = "The quick brown fox jumps over the lazy dog";
// Write the code necessary to reverse the letters of each word in place and display the result. In other words, don't just reverse every letter in the variable pangram. Instead, you'll need to reverse just the letters in each word, but print the reversed word in its original position in the message.
// If you're successful, you should get the following output:
// Output

// Copy
// ehT kciuq nworb xof spmuj revo eht yzal god


string pangram = "The quick brown fox jumps over the lazy dog";

string[] message = pangram.Split(' ');
string[] newMessage = new string[message.Length];

for (int i = 0; i < message.Length; i++)
{
    char[] letters = message[i].ToCharArray();
    Array.Reverse(letters);
    newMessage[i] = new string(letters);
}

string result = String.Join(" ", newMessage);
Console.WriteLine(result);

//challenge
// Previously, we set out to write code that would store Order IDs belonging to potentially fraudulent orders. We hope to find those fraudulent orders as early as possible and flag them for deeper analysis.
// Our team found a pattern: orders that start with the letter "B" encounter fraud 25 times the normal rate. Our job is to write new code that will output the Order ID of new orders where the Order ID starts with the letter "B." Our fraud team will use this code to investigate further.
// Using the code below as a starting point, you'll need to parse Order IDs out of a string containing a sequence of incoming orders (the orderStream). Then, you'll print each Order ID that starts with the letter "B."
// string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] items = orderStream.Split(',');

foreach (var item in items)
{
    if (item.StartsWith("B"))
    {
        Console.WriteLine(item);
    }
}

