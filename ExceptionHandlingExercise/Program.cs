using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // First create an char[], it must contain 6 numbers and 3 letters
            var arr = new char[] { '1', '2', '3', '4', '5', '6', 'a', 'b', 'c' };

            // Create a list called numbers
            var numbers = new List<int>();

            // Create an string variable with an empty string initializer
            var str = "";

            // using a foeach loop, attempt to parse the elements in your char[],
            // Exceptions will be thrown
            foreach(var letter in arr)
            {
                try
                {
                    str = letter.ToString();
                    numbers.Add(int.Parse(str));
                }
                catch(Exception e)
                {
                    LoggerError(e);
                }
            }

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }


        static void LoggerError(Exception error)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"{Environment.NewLine}-------------------------{Environment.NewLine}");
            sb.Append($"{error.Message} {DateTime.Now}");
            sb.Append($"{Environment.NewLine}-------------------------{Environment.NewLine}");
            var filePath = "";

            File.AppendAllText(filePath + "log.txt", sb.ToString());
        }
    }
}
