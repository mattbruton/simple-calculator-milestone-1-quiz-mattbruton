using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class UserInterface
    {
        public int PromptCounter = 0;

        public string Prompt()
        {
            return string.Format("[{0}]> ", PromptCounter.ToString());
        }

        public void HandleUserInput(string input)
        {
            switch (input)
            {
                case "exit":
                case "quit":
                    {
                        Environment.Exit(0);
                        break;
                    }
                default:
                    break;
            }
        }
    }
}
