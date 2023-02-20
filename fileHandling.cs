using System;
using System.IO;
namespace FileHanddling{
    class handlingFiles{
        static void Main(string[]args)
        {
            using (StreamWriter writer = new StreamWriter("data.txt"))
            {
                writer.WriteLine("3rd Day of C#");
            }

            using (StreamReader reader = new StreamReader("data.txt")){
                string allText = reader.ReadToEnd();
                Console.WriteLine(allText);
            }
        }
    }
}