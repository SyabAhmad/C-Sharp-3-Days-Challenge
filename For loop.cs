using System;
namespace forLoop{
    class foorLoopControlFlow{
        static void Main(string[] args)
        {
            List<string> fruits = new List<string> {1,3, 4, 5};
            
            for(int i=0;i<fruits.length;i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}