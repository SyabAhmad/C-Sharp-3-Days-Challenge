using System;
namespace switchcasing{
    class controlFlowSwitchCase{
        static void Main(string[] args){
            int age = 18;
            switch (age)
            {
                case 18:
                    Console.writeLine("You are On Border");
                    break;
                case 19:
                    Console.WriteLine("You are Adult");
                    break;
                default:
                Console.WriteLine("Invalid Arguments");
            }
        }
    }
}