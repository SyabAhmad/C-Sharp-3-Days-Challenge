using System;
namespace AreaOfRectangle{
    class AreaOfRectangle{
        static void Main(string[]args)
        {
            Console.WriteLine("To Calculate Area of rectangle");
            int value1 = int.Parse(Console.ReadLine());
            int value2 = int.Parse(Console.ReadLine());
            int result = value1*value2;
            Console.Write("result" + result);
            
            Console.ReadLine();
        }
    }
}