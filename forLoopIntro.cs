using System;
namespace arrays{
    class arraysInCSharp{
        static void Main(string[]args){
            Console.WriteLine("Arrays in C#");
            
            string[] fruits = {"Apple", "Banana", "Mango", "Grapes"};
            foreach (var item in fruits)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}