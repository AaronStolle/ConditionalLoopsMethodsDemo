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

            int inkLevel = PromptUser4Int("What's the ink level? ");
            

            PrintDoc(hasPower, hasPaper, inkLevel);


        }
        private static void PrintDoc(bool hasPower, bool hasPaper, int inkLevel)
        {
            Console.Write(hasPower && hasPaper && inkLevel >= 10 ? "Printing" : "Unable to print");
        }

        private static string PromptUser(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        private static int PromptUser4Int(string message)
        {
            int result;
            
            while (!int.TryParse(PromptUser(message), out result))
            {
                PromptUser("Invalid Input! Press any key to continue");
            }
            return result;
        }
    }
}
