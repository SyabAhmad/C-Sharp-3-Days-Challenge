using System;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace loginPage
{

    public class infoSection
    {
        public static string tempUserName;
        public static string tempPinCode;
        public static void input()
        {
            string tempUserName = Console.ReadLine();
            string tempPinCode = Console.ReadLine();
            validationCheck();
            if (validationCheck())
            {
                output();
            }
            else
            {
                Console.WriteLine("Incoreect Password OR User Name");
                input(); //// if its work then it is called recursion (recursive function)
            }
        }

        public static bool validationCheck()
        {
            bool idTrue = false;
            using (StreamReader reader = new StreamReader("data.txt"))
            {
                string line;
                
                while((line = reader.ReadLine()) != null)
                {
                    string[] value = line.Split("\n");
                    if (value[0] == tempPinCode)
                    {
                        idTrue =  true;
                    }
                    else
                    {
                        idTrue = false;
                    }
                }
                
            }
            return idTrue;

        }
        public static void output()
        {
            Console.WriteLine("Welcome to De Developer Coding Challenge, \n Happy Coding!!!");
        }

        



    }

    class LoginFromFile: infoSection
    {

        static void Main(string[] args)
        {
            infoSection infosection = new infoSection();
            try
            {
                using (StreamWriter writer = new StreamWriter("data.txt"))
                {
                    string userName = "developer";
                    string pinCode = "1234";
                    writer.WriteLine(userName);
                    writer.WriteLine(pinCode);
                }
            }catch (Exception ex)
            {
                ex.GetBaseException();
            }

            input();

            Console.ReadLine();
        }
    }
}