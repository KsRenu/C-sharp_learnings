// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");


            // Console.WriteLine("What is your name?");
            // var name = Console.ReadLine();
            // var currentDate = DateTime.Now;
            // Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
            // Console.Write($"{Environment.NewLine}Press any key to exit...");

            // var vare1="1234";
            // byte vare2=Convert.ToByte(vare1); This actually crashes the program So use try and catch
            // int vare2=Convert.ToInt32(vare1);
            // Console.WriteLine(vare2);
            // Console.ReadKey(true);
            
            // try{
            //     var vare1="1234";
            //     byte vare2=Convert.ToByte(vare1); 
            // }
            // catch(Exception){
            //     Console.WriteLine("Ther is some error in the code.");
            // }

            // Console.ReadKey(true);


            // int a =10;
            // System.Console.WriteLine(a);

            //byte, int, float, char, str, bool

            // int a=5;
            // System.Console.WriteLine(a);
            // double b= 1.0000009;
            // System.Console.WriteLine(b);
            // byte c=255;
            // //byte d=(int)c+1;
            // int d= c +1;
            // byte f= (byte) d;
            // System.Console.WriteLine(d);
            // System.Console.WriteLine(f);

            //System.Console.WriteLine("{0} {1}", int.MinValue, int.MaxValue);


            
            // var a=8;
            // System.Console.WriteLine(a>=8 && a>=8);






        // Microsoft In-browser tutorial
        // var name = "Renu";
        // Console.WriteLine("Hello " + name + "!");

        // var name = "Renu";
        // Console.WriteLine($"Hello {name.ToUpper()}!");


        //prints 77
        // string firstName = "Bob";
        // int widgetsSold = 7;
        // Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets.");

        //prints 14
        // string firstName = "Bob";
        // int widgetsSold = 7;
        // Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");

        //int sum = 7 + 5;
        // int difference = 7 - 5;
        // int product = 7 * 5;
        // int quotient = 7 / 5;
        // decimal decimalQuotient = 7.0m / 5;


        // decimal decimalQuotient = 7 / 5.0m;
        // decimal decimalQuotient = 7.0m / 5.0m;

        // //to get input only in int and need to produce the deci result
        // int first = 7;
        // int second = 5;
        // decimal quotient = (decimal)first / (decimal)second;

        // //to get remainders
        // Console.WriteLine("Modulus of 200 / 5 : " + (200 % 5));
        // Console.WriteLine("Modulus of 7 / 5 : " + (7 % 5));

        // Console.WriteLine("Sum: " + sum);
        // Console.WriteLine("Difference: " + difference);
        // Console.WriteLine("Product: " + product);
        // Console.WriteLine("Quotient: " + quotient);
        // Console.WriteLine("Decimal quotient: " + decimalQuotient);


        //operators
        // int value = 1;

        // value = value + 1;
        // Console.WriteLine("First increment: " + value);

        // value += 1;
        // Console.WriteLine("Second increment: " + value);

        // value++;
        // Console.WriteLine("Third increment: " + value);

        // value = value - 1;
        // Console.WriteLine("First decrement: " + value);

        // value -= 1;
        // Console.WriteLine("Second decrement: " + value);

        // value--;
        // Console.WriteLine("Third decrement: " + value);




        //int value = 1;
        // value++;
        // Console.WriteLine("First: " + value);
        // Console.WriteLine("Second: " + value++);
        // Console.WriteLine("Third: " + value);
        // Console.WriteLine("Fourth: " + (++value));


        Random dice = new Random();
        int roll = dice.Next(1, 7);
        Console.WriteLine(roll);
        }
    }
}
