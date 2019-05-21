using System;

namespace OptimalStrategyRestricted
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Optimal Strategy for a game where user can move only from front!");
            Console.WriteLine("---------------------------------------------------------------");

            int[] array = InputProcessor.GetArrayFromInput();
            Console.WriteLine("Winner's winning amount[not necessarily winning] is " +
                InputProcessor.GetWinnerAmount(array));

            Console.ReadLine();
        }
    }
}
