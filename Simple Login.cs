using System;
namespace simpleLoginPage{
  class simpleLoginPage{
    static void main(string[]args)
    {
      string userName = "de Developer";
      int pinCode = 1234;
      string tempUserName = Console.ReadLine();
      int tempPinCode = int.Parse(Console.ReadLine());
      if(tempPinCode == pinCode)
      {
        Console.WriteLine("Welcome");
      }else{
        Console.WriteLine("Incorrect PinCode: Try Again");
      }
    }
  }
}