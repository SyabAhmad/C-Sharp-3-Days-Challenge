using System;
namespace functionsInCSharp{
    class calculations{
        int addition(int a, int b)
        {
            return a+b;
        }

        int subtraction(int a, int b)
        {
            return a-b;
        }

        int mutiplication(int a, int b)
        {
            return a*b;
        }

        int division(int a, int b)
        {
            return a/b;
        }

        int madulas(int a, int b)
        {
            return a%b;
        }
        int power(int a, int b)
        {
            return a**b;
        }

        static void Main(string[] args)
        {
            calculations calcu = new calculations();
            Console.WriteLine(calcu.addition(2,4));
            Console.WriteLine(calcu.subtraction(2,4));
            Console.WriteLine(calcu.mutiplication(2,4));
            Console.WriteLine(calcu.division(2,4));
            Console.WriteLine(calcu.madulas(2,4));
            Console.WriteLine(calcu.power(2,4));

            Console.ReadLine();

        }
    }
}