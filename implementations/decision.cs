using System;
using System.Linq;
namespace implementation{
    class implementations{
        static void m1(){//without para
                System.Console.WriteLine("From m1");
            }
        static void m2(string s6,int n6){//with para
            System.Console.WriteLine(s6+ "  " + n6);
        }
        static void m3(string s7="s7"){//with default para
            System.Console.WriteLine(s7);
        }
        static int m4(int n7,int n8){//with return value
            return n7+n8;
        }
        static void m5(int n9,int n10){//named arguments
            System.Console.WriteLine(n9 + "   " + n10);
        }
        static void m6(int n11){//method overloading
            System.Console.WriteLine("Its int " + n11);
        }
        static void m6(double d1){
            System.Console.WriteLine("Its double " + d1);
        }
        static void Main(string[] args){

            //if..else if...else
            int n1=1;
            int n2=2;
            if (n1==1){
                System.Console.WriteLine("n1 is 1");
            }
            else if(n2==2){
                System.Console.WriteLine("n2 is 2");
            }
            else{
                System.Console.WriteLine("unknown n1 and n2");
            }
            //ternary operator
            int n3 = (n2>n1)?n2:n1;
            System.Console.WriteLine(n3);

            //switch case
            switch(n2){
                case 1:
                System.Console.WriteLine("n1");
                break;
                case 2:
                System.Console.WriteLine("n2");
                break;
                default:
                System.Console.WriteLine("unknown");
                break;
            
            }


            //looping
            //while
            while(n2<5){
                System.Console.WriteLine(n2);
                n2+=1;
            }

            //do....while
            do{
                System.Console.WriteLine(n2);
                n2-=1;
            }
            while(n2>2);
            
            //for

            for(int i=0;i<5;i++){
                System.Console.WriteLine(i);
            }

            //foreach loop
            string[] s1={"s2","s3","s4","s5"};
            foreach(string s6 in s1){
                System.Console.WriteLine(s6);
            }

            //array
            System.Console.WriteLine(s1.Length);
            //initialising the array
            string[] s2 = new string[4];
            string[] s3 = new string[4] {"s2","s3","s4","s5"};
            string[] s4 = new string[] {"s2","s3","s4","s5"};
            string[] s5={"s2","s3","s4","s5"};

            int[] n4={1,2,6,5};
            Array.Sort(n4);
            foreach(int j in n4){
                System.Console.WriteLine(j);
            }

            //using System.Linq;
            Console.WriteLine(n4.Max());  // returns the largest value
            Console.WriteLine(n4.Min());  // returns the smallest value
            Console.WriteLine(n4.Sum());

            //multi-dimensional array
            int[,] n5={ {1, 4, 2}, {3, 6, 8} };
            foreach (int i in n5)//accessing elements using foreach
            {
            Console.WriteLine(i);
            }
            System.Console.WriteLine("using for loop");
            for (int i = 0; i < n5.GetLength(0); i++) //use getlength not length
            { 
            for (int j = 0; j < n5.GetLength(1); j++) 
            { 
                Console.WriteLine(n5[i, j]); 
            } 
            }  
            //methods
            m1();
            m2("s6",5);
            m3();
            int n8= m4(3,4);
            System.Console.WriteLine(n8);
            m5(n10:2,n9:1);
            m6(3);
            m6(4.567D);
        }
    }
}