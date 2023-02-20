 using System;
namespace inheritenceinCSharp{
    public class animals{
        public string name;
        public void eat()
        {
            Console.WriteLine(name + " are Eating");
        }
    }
    public class dog : animals{
        public void barking(){
            Console.WriteLine(name + " is barking");
        }
    }
    class inheritence{
        static void Main(string[]args)
        {
            dog dog1 = new dog();
            dog1.name = "botal";
            dog1.barking();
            dog1.eat();
        }
    }
}