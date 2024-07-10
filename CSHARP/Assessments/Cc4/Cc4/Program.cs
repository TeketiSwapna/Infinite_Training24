using System;
using System.IO;

namespace Cc4
{
    class Append_txt
    {
        static void Main()
        {
            Console.WriteLine("write a message do you want to append in the file");
            string fileName = "sample.txt";
            string textToAppend = Console.ReadLine();

            try
            {
                using (StreamWriter fileStream = File.CreateText(fileName))
                {
                    fileStream.WriteLine("Hlo team");
                    fileStream.WriteLine("Today C# sharp coding challenge4 assessement");
                }

                using (StreamWriter sw = new StreamWriter(fileName, true))
                {
                    sw.WriteLine(textToAppend);
                }
                Console.WriteLine("Text appended to the file successfully.");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}