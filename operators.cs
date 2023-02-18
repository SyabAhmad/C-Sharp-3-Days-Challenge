using System;
namespace operators{
    class operatorinCSharp{
        static void main(string[]args)
        {
            Console.WriteLine("Athematic Operators");
            int firstValue = 21;
            int secondValue = 21;
            /// to add use Addition operator which is Athematic  oparator
            int result = firstValue + secondValue;
            Console.WriteLine(result);
            /// to subtract use the subtraction operator which is Athematic  oparator
             result = firstValue-secondValue;
            Console.WriteLine(result);
            /// to multiplyn use the muyltiplication variables which is Athematic  oparator
             result = firstValue*secondValue;
            Console.WriteLine(result);
            /// to divide use the division operator which is Athematic  oparator
             result = firstValue/secondValue;
            Console.WriteLine(result);
            //// to find madulas use % operator which is deffinatly Athematic  operator
             result = firstValue%secondValue;
            Console.WriteLine(result);



            Console.WriteLine("Comparison  operators");
            /// ==, >=, <=, <, >, !, 
            bool isTrue;
            /// to check if the values are equal
            isTrue = firstValue == secondValue;
            Console.WriteLine(isTrue);
            /// to check if the first Value is equal or less the second Value
            isTrue = firstValue <= secondValue;
            Console.WriteLine(isTrue);
            /// to check if the firstvalue is greater then or equal to second value
            isTrue = firstValue >= secondValue;
            Console.WriteLine(isTrue);
            /// to check if the first vale is not equal to second value
            isTrue = firstValue != secondValue;
            Console.WriteLine(isTrue);
            /// to chek weather the first value is greater the second value
            isTrue = firstValue > secondValue;
            Console.WriteLine(isTrue);
            /// to check weather the first value is less then the second value or not
            isTrue - firstValue < secondValue;
            Console.WriteLine(isTrue);

            Console.WriteLine("Logical Operators");
            //// && || !

            /// &&& used for  'and' which means both sid values from the 'and' Symbols
            Console.WriteLine(firstValue && secondValue);
            /// || used for 'or' which means one of the side from both side values from the 'or' sumbols
            Console.WriteLine(firstValue || secondValue);
            // used for not equals to
            Console.WriteLine( !firstValue);
            

            Console.WriteLine("BitWise Operators");
            /// uses bit by bit method
            bool isTrue;

            isTrue = firstValue & secondValue;
            Console.WriteLine(isTrue);

            isTrue = firstValue << secondValue;
            Console.WriteLine(isTrue);

            isTrue = firstValue >> secondValue;
            Console.WriteLine(isTrue);

            isTrue = ~firstValue;
            Console.WriteLine(isTrue);
   
            isTrue = firstValue |  secondValue;
            Console.WriteLine(isTrue);
            
            isTrue - firstValue ^ secondValue;
            Console.WriteLine(isTrue);



            Console.WriteLine("Assignment Operator");
            //// +=, -+, *=, /=, %  
            
            int result = 90;
             result = 10;
            Console.WriteLine(result);

             result += 2;
            Console.WriteLine(result);

             result -= 2;
            Console.WriteLine(result);

             result *= 3;
            Console.WriteLine(result);

             result /= 2;
            Console.WriteLine(result);

             result %= 2;
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}