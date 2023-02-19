using System;
namespace SumOfEvenNumber{
  class SumOfEvenNumber{
    static void Main(string[]args)
    {
      int totalSum = 0;
      int value =int.Parse(Console.ReadLine());
      for(int i=0;i<value;i++)
      {
        if(i%2==0)
        {
          totalSum = totalSum+i;
        }
      }
      Console.WriteLine("Total Sum is equal to : " + totalSum);
    }
  }
}