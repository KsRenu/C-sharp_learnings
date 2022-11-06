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
            
            try{
                var vare1="1234";
                byte vare2=Convert.ToByte(vare1); 
            }
            catch(Exception){
                Console.WriteLine("Ther is some error in the code.");
            }

            
            Console.ReadKey(true);
        }
    }
}
