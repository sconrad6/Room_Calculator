using System;
namespace Room_Calculator
{
    public class RoomCalculatorTest
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Circus Room Detail Generator!");

            char userDecision;
            char userWouldLikeVolume;
            do
            {
                Console.WriteLine("\nEnter Width:");
                double width = Convert.ToDouble(Console.ReadLine()); 
                Console.WriteLine("Enter Length:");
                double length = Convert.ToDouble(Console.ReadLine()); 
                RoomCalculator room1 = new RoomCalculator(length, width);
                Console.WriteLine(room1);
                Console.Write("\nWould you like to calculate the volume of the room? Press 'Y' for yes and 'N' for no.");
                // userWouldLikeVolume = Console.ReadKey().KeyChar;
                userWouldLikeVolume = Console.ReadKey().KeyChar;
                if (userWouldLikeVolume == 'Y' || userWouldLikeVolume == 'y')
                {
                    Console.WriteLine("\nPlease enter the room's height:");
                    double height = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Volume:" + room1.Volume(height));
                }
                Console.Write("\nWould you like to calculate for another room? Press 'Y' for yes and 'N' for no.\n");
                userDecision = Console.ReadKey().KeyChar;
            } while (userDecision == 'Y' || userDecision == 'y');
            Console.WriteLine("\n\nThank you, and goodbye.");
        }
    }
}


/* 1. Promt the user to input data that you are intertested in collecting, by first using a 'Console.WriteLine();' 
 and then using 'Console.ReadLine()' to read the user data into the program
 2. To do the calculations, methods are created in the RoomCalculator class that uses the data from the user to do the calculations.  
 Volume, area, and perimeter all have their own methods, which are then accessed in the main method.
 3.  To display the calculations back to the user, an instance of the class RoomCalculator is created, named room1 in this example.
 This creates and instance of the class with the stored data from the user, and uses that to access the volume, area, and perimeter methods.
 A ToString method is also constructed to easily print the area and perimeter of the room using 'Console.WriteLine(room1);' 
 */



