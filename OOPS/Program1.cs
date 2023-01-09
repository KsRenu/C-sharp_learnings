class c1{
        public void c1Fun(){
            //string s1="s1"; //fields of a class
            System.Console.WriteLine("c1");//method pf a class
        }
    }

class c2{
    public c2(){//A constructor is a special method that is used to initialize objects
        System.Console.WriteLine("from c2 constructor");
    }
    public void c2Fun()
    {
        System.Console.WriteLine("c2");
    }
}

class c3{
    public c3(string s1){//constructor with parameters
        s1=s1;
        System.Console.WriteLine("The s1 is : " + s1);
    }
}

// class c4{
//     public c4(){
//         public string s2 = "s2";
//         System.Console.WriteLine("s2 value from c4");
//     }
// }

class Person
{
  public string Name  // property
  { get; set; }
}

class c5{
    public void c5Func(){
        System.Console.WriteLine("From c5 parent");
    }
}
class c6 : c5{
    public void c6Func()
    {
        System.Console.WriteLine("From c6 child");
    }
}
//sealed class Vehicle  //to prevent from other class accessing it


// class c7{
//     public virtual void c7Func(){ //polymorphism 
//         System.Console.WriteLine("from c7");
//     }
// }
// class c8 : c7{
//     public override void c7Func(){
//         System.Console.WriteLine("from c8"); // without virtual in c7Func in c7 class and override in c7Func in c8 class override doesnt function
//     }
// }

abstract class c9{
    public abstract void c9Func();
    public c9(){
        System.Console.WriteLine("inside c9");
    } 
}

class c10 : c9{
    public override void c9Func()
    {
        System.Console.WriteLine("Inside c10");
    }
}

interface Ic11{
    void c11Func1();
    void c11Func2();

}

class c12 : Ic11{
    public void c11Func1(){
        System.Console.WriteLine("inside c11Func1");
    }
    public void c11Func2(){
        System.Console.WriteLine("inside c11Func2");
    }
}

//class DemoClass : IFirstInterface, ISecondInterface    for multiple interfaces