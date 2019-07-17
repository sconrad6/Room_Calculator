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
            Console.WriteLine("\n\nThank you, and goodbye. ");
        }
    }
}






