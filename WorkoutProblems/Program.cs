﻿// See https://aka.ms/new-console-template for more information
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


//Dice game
Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}

if (total >= 16)
{
    Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a kitten!");
}


//expire code
Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20;
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    discountPercentage = 10;
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
}



//for each code
int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int bin = 0;
foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}
Console.WriteLine($"We have {sum} items in inventory.");


//Our team found a pattern. Orders that start with the letter "B" encounter fraud 25 times the normal rate. We will write new code that will output the Order ID of new orders where the Order ID starts with the letter "B". This will be used by our fraud team to investigate further.
//solution
string[] ids={"B123","C234","A345","C15","B177","G3003","C235","B179"};
foreach(string id in ids ){
    if(id.StartsWith("B")){
        Console.WriteLine(id);
    }
}


//increase the readability of the code
/*
   This code reverses a message, counts the number of times 
   a particular character appears, then prints the results
   to the console window.
 */

string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] message = originalMessage.ToCharArray();
Array.Reverse(message);

int letterCount = 0;

foreach (char letter in message)
{
    if (letter == 'o')
    {
        letterCount++;
    }
}

string newMessage = new String(message);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times.");

//Calling a method in the same class


namespace MyNewApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "Microsoft Learn";
            string reversedValue = Reverse(value);
            Console.WriteLine($"Secret message: {reversedValue}");
        }

        static string Reverse(string message)
        {
            char[] letters = message.ToCharArray();
            Array.Reverse(letters);
            return new string(letters);
        }
    }
}

//Calling a method from a different class


namespace MyNewApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "Microsoft Learn";
            string reversedValue = Utility.Reverse(value);
            Console.WriteLine($"Secret message: {reversedValue}");
        }
    }

    class Utility
    {
        public static string Reverse(string message)
        {
            char[] letters = message.ToCharArray();
            Array.Reverse(letters);
            return new string(letters);
        }
    }
}


//Referencing a class in a different namespace


namespace MyNewApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "Microsoft Learn";
            string reversedValue = MyNewApp.Utilities.Utility.Reverse(value);
            Console.WriteLine($"Secret message: {reversedValue}");
        }
    }
}

namespace MyNewApp.Utilities
{
    class Utility
    {
        public static string Reverse(string message)
        {
            char[] letters = message.ToCharArray();
            Array.Reverse(letters);
            return new string(letters);
        }
    }
}


//The using statement helps the compiler resolve namespaces, but with fewer keystrokes

using MyNewApp.Utilities;

namespace MyNewApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "Microsoft Learn";
            string reversedValue = Utility.Reverse(value);
            Console.WriteLine($"Secret message: {reversedValue}");
        }
    }
}

namespace MyNewApp.Utilities
{
    class Utility
    {
        public static string Reverse(string message)
        {
            char[] letters = message.ToCharArray();
            Array.Reverse(letters);
            return new string(letters);
        }
    }
}


//challenge
//Rewrite and fix the problematic code in the .NET Editor
int[] numbers = { 4, 8, 15, 16, 23, 42 };
foreach (int number in numbers)
{
    int total;
    total += number;
    if (number == 42)
    {
       bool found = true;
    }
}
if (found) 
{
    Console.WriteLine("Set contains 42");
}
Console.WriteLine($"Total: {total}");

//solution
int[] numbers = { 4, 8, 15, 16, 23, 42 };
bool found=false;
int total=0;
foreach (int number in numbers)
{
    
    total += number;
    if (number == 42)
    {
        found = true;
    }
}
if (found) 
{
    Console.WriteLine("Set contains 42");
}
Console.WriteLine($"Total: {total}");


//code that uses a conditional operator
int saleAmount = 1001;

int discount = saleAmount > 1000 ? 100 : 50;

Console.WriteLine($"Discount: {discount}");

//Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

//challenge
// Use the Random class to generate a value. Based on the value, use the conditional operator to display either heads or tails.
// There should be a 50% chance that the result is either heads or tails.
// You should be able to accomplish the desired result in three lines of code or less.
// Whether you get stuck and need to peek at the solution or you finish successfully, continue on to view a solution to this challenge.

    Random coin = new Random();
int flip = coin.Next(0, 2);
Console.WriteLine((flip == 0) ? "heads" : "tails");


//challenge
// string permission = "Admin|Manager";
// int level = 55;
// If the user is an Admin with a level greater than 55, output the message:

// Welcome, Super Admin user.
// If the user is an Admin with a level less than or equal to 55, output the message:
// Output

// Welcome, Admin user.
// If the user is a Manager with a level 20 or greater, output the message:
// Output


// Contact an Admin for access.
// If the user is a Manager with a level less than 20, output the message:
// Output


// You do not have sufficient privileges.
// If the user is not an Admin or a Manager, output the message:
// Output


// You do not have sufficient privileges.


//solution
string permission = "Admin";
int level = 56;
if ((permission!="Admin")&(permission!="Manager")){
    Console.WriteLine("You do not have sufficient privileges.");
}
else{
    if(permission=="Admin") Console.WriteLine($"{(level<=55?"Welcome, Admin user.":"Welcome, Super Admin user.")}");
    else Console.WriteLine($"{(level>=20?"Contact an Admin for access.":"You do not have sufficient privileges.")}");
}


//challenge
// FizzBuzz rules:
// Output values from 1 to 100, one number per line.
// When the current value is divisible by 3, print the term Fizz next to the number.
// When the current value is divisible by 5, print the term Buzz next to the number.
// When the current value is divisible by both 3 and 5, print the term FizzBuzz next to the number.

//solution by me
for(int i=0;i<=25;i++){
    if (i%3 == 0 ){
        if (i%5 == 0){
            Console.WriteLine(i+ "- FizzBuzz");
        }
        else{
        Console.WriteLine(i+ "- Fizz");}
    
    }
    else if ((i%5 ==0)&(i%3!= 0 )){
        Console.WriteLine(i+ "- Buzz");
    }
    else{
        Console.WriteLine(i);
    }
}

//solution gn:
for (int i = 1; i < 101; i++)
{
    if ((i % 3 == 0) && (i % 5 == 0))
        Console.WriteLine($"{i} - FizzBuzz");
    else if (i % 3 == 0)
        Console.WriteLine($"{i} - Fizz");
    else if (i % 5 == 0)
        Console.WriteLine($"{i} - Buzz");
    else
        Console.WriteLine($"{i}");
}


//Write a do-while statement to break when a certain random number is generated

//write code that will keep generating random numbers between 1 and 10 until it generates the number 7. This could take one iteration, or could possibly take dozens of iterations.

Random random = new Random();
int current = 0;

do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);

//Write a while statement that iterates only while a random number is greater than some value
Random random = new Random();
int current = random.Next(1, 11);

/*
do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);
*/

while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");



Random random = new Random();
int current = random.Next(1, 11);

do
{
    current = random.Next(1, 11);

    if (current >= 8) continue;

    Console.WriteLine(current);
} while (current != 7);

/*
while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");
*/


//CHALLENGE

// Role playing game battle challenge
// In most role playing games, the player's character battles non-player characters, which are usually monsters or the "bad guys." Usually, a battle consists of each character generating a random value using dice, and that value is subtracted from the opponent's health score. Once either character's health reaches zero, they die or lose.
// In this challenge, we'll boil down that interaction to its essence. A hero and a monster start with the same health score. During the hero's turn, they'll generate a random value that will be subtracted from the monster's health. If the monster's health is greater than zero, they'll take their turn and attack the hero. As long as both the hero and the monster have health
//  greater than zero, the battle will resume.

int hero = 10;
int monster = 10;

Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");