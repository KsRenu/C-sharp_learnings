// Questions:
// Create a function that takes an array of arrays with numbers. Return a new (single) array with the largest numbers of each.
// ATM machines allow 4 or 6 digit PIN codes and PIN codes cannot contain anything but exactly 4 digits or exactly 6 digits. Your task is to create a function that takes a string and returns true if the PIN is valid and false if it's not.
// Create a function that determines whether elements in an array can be re-arranged to form a consecutive list of numbers where each number appears exactly once.
// Given an integer, create a function that returns the next prime. If the number is prime, return the number itself.



using System;
public class SampleProblems
{
   public static int arrayLarge(int[][] arr){
    
        for (int i = 0; i < arr.Length; i++)
        {
            System.Console.Write("Element({0}): ", i);

            for (int j = 0; j < arr[i].Length; j++)
            {
                System.Console.Write("{0}{1}", arr[i][j], j == (arr[i].Length - 1) ? "" : " ");
            }
            System.Console.WriteLine();
        }
        return 0;
   }
    
    static void Main()
    {
        int[][] arr = new int[2][];
        arr[0] = new int[5] { 1, 3, 5, 7, 9 };
        arr[1] = new int[4] { 2, 4, 6, 8 };
        arrayLarge(arr);
    }
}
   