using System;
namespace MTableForValue{
  class MTableForValue{
    static void Main(string[]args)
    {
      int value =int.Parse(Console.ReadLine());
      for(int i=0;i<=10;i++)
      {
        Console.WriteLine(value + " * " + i + " = " + value*i);
      }
      
    }
  }
}