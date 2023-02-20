using System;
namespace functionsInCSharps{
    class toFindMaxValue{
        static int getMax(int a, int b)
        {
            if(a<b)
            {
                return a;
            } else{
                return b;
            }
        }
        static void Main(string[] args)
        {
            int newValue = getMax(2,6);
            Conosle.WriteLine(newValue);

            ///// or we can i directly do that here
            Consoles.WriteLine(getMax(3,6));
        }
    }
}