using System;
namespace exception{
    class tryCatchFinally{
        static void Main(string []args)
        {
            int val1 = 10;
            int val2 =2;
            try
            {
                int result = val1/val2;
                COnsole.WriteLine("Result = " + result);
            }
            catch (DivideByZeroException e)
            {
                e.getMessage(); /// or some thin message you want to display
            }
            finally{
                Console.WriteLine("will always executed ");
            }
        }
    }
}