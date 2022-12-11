// Questions:
// Create a function that takes two numbers as arguments (num, length) and returns an array of multiples of num until the array length reaches length.
// Create a function that takes an array of arrays with numbers. Return a new (single) array with the largest numbers of each.
// ATM machines allow 4 or 6 digit PIN codes and PIN codes cannot contain anything but exactly 4 digits or exactly 6 digits. Your task is to create a function that takes a string and returns true if the PIN is valid and false if it's not.
// Create a function that determines whether elements in an array can be re-arranged to form a consecutive list of numbers where each number appears exactly once.
// Given an integer, create a function that returns the next prime. If the number is prime, return the number itself.



using System;
public class SampleProblems
{
    public static int Sum(int num1, int num2){// Create a function that takes two numbers as arguments and returns their sum.
    
        return num1 + num2;
    }

    public static int minToSec(int min){//Write a function that takes an integer minutes and converts it to seconds.
        return min*60;
    }
     
     public static int increment(int num1){// Create a function that takes a number as an argument, increments the number by +1 and returns the result.
        return num1+1;
     }

     public static int power(int voltage,int current){// Create a function that takes voltage and current and returns the calculated power.
        return voltage*current;
     }

     public static int areaOfTriangle(int baseValue,int height){// Write a function that takes the base and height of a triangle and return its area.
        int area = 1/2*(baseValue*height);
        return area;
     }
    public static void Main()
    {
	  Console.Write("Enter num1: ");
      int n1= Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter num2: ");
      int n2= Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("sum : {0} \n", Sum(n1,n2) );

      Console.Write("Enter min value: ");
      int min= Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("min : {0} \n", minToSec(min) );

      Console.Write("Enter Number value: ");
      int num1= Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Incremented value : {0} \n", increment(num1) );

      Console.Write("Enter voltage value: ");
      int voltage= Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter current value: ");
      int current= Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Power value is : {0} \n", power(voltage,current) );

      Console.Write("Enter Base value: ");
      int baseValue=Convert.ToInt32(Console.ReadLine() );
      Console.Write("Enter Height value: ");
      int height= Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Power value is : {0} \n", areaOfTriangle(baseValue,height) );
    }
}