using System;
using System.IO;

namespace oops
{
    class program{
        enum Months{
                January,    // 0
                February,   // 1
                March,      // 2
                April,      // 3
                May=10,        // 4
                June,       // 11
                July        // 12
            }
        public static void Main(string[] args){
            c1 c1Obj= new c1();
            c1Obj.c1Fun();//calling function of a class from another file
            c2 c2Obj = new c2();
            c2Obj.c2Fun();
            c3 c3Obj= new c3("s1");
            //c4 c4Obj= new c4();
            //System.Console.WriteLine("s2 from thi class" + c4Obj.s2); will throw error as s2 is private
            
            Person myObj = new Person();//use short-hand / automatic properties
            myObj.Name = "Liam";
            Console.WriteLine(myObj.Name);
            c6 c6Obj = new c6();
            c6Obj.c6Func();
            c6Obj.c5Func();
            // c7 c7Obj = new c7();
            // c7Obj.c7Fun();
            // c8 c8Obj = new c8();
            // c8Obj.c7Fun();
            c10 c10Obj = new c10();
            c10Obj.c9Func();
            c12 c12Obj= new c12();
            c12Obj.c11Func1();
            c12Obj.c11Func2();

            //operations on enum
            int n1 = (int) Months.April;
            System.Console.WriteLine(n1);
            int n2 = (int) Months.June;
            System.Console.WriteLine(n2);

            Months myVar = Months.April;
            switch(myVar){
                case Months.February : 
                System.Console.WriteLine("Feb");
                break;
                case Months.April:
                System.Console.WriteLine("April");
                break;
            }

            //using System.IO needed to access and perform operations on the file system.
            string writeText = "Hello World!";  
            File.WriteAllText("file1.txt", writeText); 
            string readText = File.ReadAllText("file1.txt");  
            Console.WriteLine(readText);  


            //exception
            try
            {
            int[] myNumbers = {1, 2, 3};
            Console.WriteLine(myNumbers[10]);
            }
            catch (Exception e)
            {
            Console.WriteLine("Something went wrong.");
            }
            finally
            {
            Console.WriteLine("The 'try catch' is finished.");
            }


            //throw key word
            static void checkAge(int age)
            {
            if (age < 18)
            {
                throw new ArithmeticException("Access denied - You must be at least 18 years old.");
            }
            else
            {
                Console.WriteLine("Access granted - You are old enough!");
            }
            }

            checkAge(15);
        }
    }
}