using System;
namespace averageOfInputNumbers{
    class averageOfInputNumbers{
        static void Main(string[]args)
        {
            Console.WriteLine("To Calculate Average of Number enterd bu users");
            int totalNumber = int.Parse(Console.ReadLine());
            int totalSum = 0;
            for(int i=0;i<totalNumber;i++)
            {
                Console.Write("Enter Next Value:  ");
                totalSum = totalSum+i;
            }
            Console.WriteLine("result = " + totalSum/totalNumber);
            
            Console.ReadLine();
        }
    }
}