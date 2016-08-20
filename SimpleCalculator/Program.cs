using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInterface UI = new UserInterface();

            while (true)
            {
                Console.Write(UI.Prompt());
                UI.HandleInput(Console.ReadLine());
            }
        }
    }
}
