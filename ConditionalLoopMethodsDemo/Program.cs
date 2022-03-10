using System;

namespace ConditionalLoopMethodDemo
{
    class Mainclass
    {
        static void Main()
        {
            
            Console.WriteLine("Enter an initial number: ");
            int startingNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a target number: ");
            int targetNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a range: ");
            int range = int.Parse(Console.ReadLine());

            string results = IsWithinRange(startingNum, targetNum, range) ? "It's within range." : "It's not within range.";

            Console.WriteLine($"Given a starting number of: {startingNum} and a target number: {targetNum}. " +
                $"{results}");
        }

        //access modifier - static(no not) - return type - name(parms in here)
        private static bool IsWithinRange(int num, int target, int range)
        {
            return Math.Abs(num - target) <= range;
        }
    }
}