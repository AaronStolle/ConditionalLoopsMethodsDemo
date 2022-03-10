using System;

namespace ConditionalLoopMethodDemo
{
    class Mainclass
    {
        static void Main()
        {
            


            Console.Write("Do we have power? (y/n) ");
            bool hasPower = Console.ReadLine().ToLower() == "y";

            Console.Write("Do we have paper? (y/n) ");
            bool hasPaper = Console.ReadLine().ToLower() == "y";

            Console.Write("What's the ink level? ");
            int inkLevel = int.Parse(Console.ReadLine());

            PrintDoc(hasPower,hasPaper,inkLevel);


        }
        private static void PrintDoc(bool hasPower, bool hasPaper, int inkLevel)
        {
            Console.Write(hasPower && hasPaper && inkLevel >= 10 ? "Printing" : "Unable to print");
        }
    }
}
