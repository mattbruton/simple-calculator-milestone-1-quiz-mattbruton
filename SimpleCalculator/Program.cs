using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInterface UI = new UserInterface();

            Console.Write(UI.Prompt());
            UI.HandleUserInput(Console.ReadLine());
        }
    }
}
