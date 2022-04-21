using System;
using System.Globalization;

namespace daysUntilChristmas
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Req 2
            string myName = "Nate";
            string myLocation = "Ammon, Idaho";

            //Req 3
            Console.WriteLine($"My name is {myName}");
            Console.WriteLine($"I am from {myLocation}");

            //Req 4
            DateTime today = DateTime.Today;
            Console.WriteLine(today.ToString("d")); 

            //Req 5
            DateTime christmas = new DateTime(2022, 12, 25); 
            TimeSpan difference = christmas - today;
            Console.WriteLine("There are " + difference.Days + " days until Christmas!");

            //Req 6
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.Write("What is the width: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.Write("What is the height: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;

            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");

            Console.ReadKey();
        }
    }
}
