using System;
namespace Variables{

    class VariablesProgram{

        static void Main(string[]args){

            int age = 21;
            string name= "de Developer";
            bool isMale = true;
            Console.WriteLine("Hello Mr." + name);
            Console.WriteLine("Your age is" + age);
            Console.WriteLine("and your Gender is "+ isMale);

            Console.ReadLine();
        }
    }
}