using BowlingExampleTemplate.Bowling;
using System;

namespace BowlingExampleTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            BowlingLogic bowlingLogic = new BowlingLogic();
            BowlingLogic bowlingLogic2 = new BowlingLogic();

            /*rollMany(12, 10, bowlingLogic);
            int result = bowlingLogic.Score();
            Console.WriteLine(result);*/

            rollSpare(bowlingLogic2);
            int result2 = bowlingLogic2.Score();
            Console.WriteLine("Roll spare is: " + result2);
           
        }
        private static void rollMany(int rolls, int pins, BowlingLogic bowlingLogic)
        {
            for (int i = 0; i < rolls; i++)
            {
                bowlingLogic.Roll(pins);
            }
        }

        private static void rollSpare(BowlingLogic bowlingLogic2)
        {
            //bowlingLogic2.Roll(new int[] { 1, 3, 7, 3, 10, 1, 7, 5, 2, 5, 3, 8, 2, 8, 2, 10, 9, 0 });
            bowlingLogic2.Roll(5);
            bowlingLogic2.Roll(5);
            bowlingLogic2.Roll(5);
            bowlingLogic2.Roll(3);
        }
    }
}
