using System;
namespace classes{


    public class name1{
        public string firstName = "de";
        public string secondName = "Developer";
        public void fullName(){
            Console.WriteLine(firstName + " " + secondName);
        }
    }


    class usingclassesinCSharp{
        static void Main(string[]args)
        {
            name1 name = new name1();
            name.fullName();
        }
    }
}