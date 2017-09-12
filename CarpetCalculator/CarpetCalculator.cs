using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarpetCalculator
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            double roomWidth, roomLength, pricePerSquareYard, numOfSquareYards;



            DisplayInstructions();



            roomLength = GetDimension("Length");
            roomWidth = GetDimension("Width");
            pricePerSquareYard = GetPrice();
            numOfSquareYards = DetermineSquareYards(roomWidth, roomLength);
            DisplayResults(numOfSquareYards, pricePerSquareYard);


            Console.ReadKey();
        }



        public static void DisplayInstructions()
        {
            Console.WriteLine("This program will determine how much carpet to purchase.");
            Console.WriteLine();
            Console.WriteLine("You will be asked to enter the side of the room and the price of the carpet, in price sper square yards.");
            Console.WriteLine();
        }



        public static double GetDimension(string side)
        {
            string inputValue;
            int feet, inches;



            Console.Write("Enter the {0} in feet: ", side);
            inputValue = Console.ReadLine();
            feet = int.Parse(inputValue);
            Console.Write("Enter the {0} in inches: ", side);
            inputValue = Console.ReadLine();
            inches = int.Parse(inputValue);



            return (feet + (double)inches / 12);
        }



        public static double GetPrice()
        {
            string inputValue;
            double price;
            Console.Write("Enter the price per Square Yard: ");
            inputValue = Console.ReadLine();
            price = double.Parse(inputValue);
            return price;
        }



        public static double DetermineSquareYards (double width, double length)
        {
            const int SQ_FT_PER_YARD = 9;
            double numOfSquareYards;
            numOfSquareYards = length * width / SQ_FT_PER_YARD;
            return numOfSquareYards;
        }



        public static double DeterminePrice ( double squareYards, double pricePerSquareYard)
        {
            return (pricePerSquareYard * squareYards);
        }



        public static void DisplayResults(double squareYards, double pricePerSquareYard)
        {
            Console.WriteLine();
            Console.Write("Square Yards Needed: ");
            Console.WriteLine("{0:N2}", squareYards);
            Console.Write("Total Cost @ {0:C} ", pricePerSquareYard);
            Console.WriteLine(" per square yard: {0:C}", DeterminePrice(squareYards, pricePerSquareYard));
        }
    }
}
