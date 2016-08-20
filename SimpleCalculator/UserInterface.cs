using System;
using System.Text.RegularExpressions;

namespace SimpleCalculator
{
    public class UserInterface
    {
        Expression exp = new Expression();
        Evaluator eval = new Evaluator();
        Constants con = new Constants();
        Stack stack = new Stack();

        public int PromptCounter = 0;

        public string Prompt()
        {
            return string.Format("[{0}]> ", PromptCounter.ToString());
        }

        private string AnswerPrefix()
        {
            return "   =";
        }

        public void CheckInputPattern(string input)
        {
            if (exp.CheckInputForConstPattern(input))
            {
                Match constMatch = exp.constPattern.Match(input);
                exp.Value_2 = Convert.ToInt32(constMatch.Groups["Value2"].Value);
                exp.Value_1 = con.ConstantList[constMatch.Groups["Value1"].Value];
                exp.Operator = Convert.ToChar(constMatch.Groups["Operator"].Value);
                eval.EvaluateUserInput(exp.Value_1, exp.Value_2, exp.Operator);
                exp.IsValidInput = true;
            }
            else if (exp.CheckInputForConstPattern2(input))
            {
                Match constMatch = exp.constPattern2.Match(input);
                exp.Value_1 = Convert.ToInt32(constMatch.Groups["Value1"].Value);
                exp.Value_2 = con.ConstantList[constMatch.Groups["Value2"].Value];
                exp.Operator = Convert.ToChar(constMatch.Groups["Operator"].Value);
                eval.EvaluateUserInput(exp.Value_1, exp.Value_2, exp.Operator);
                exp.IsValidInput = true;
            }
            else
            {
                exp.CheckIfUserInputIsValid(input);
            }
        }

        public void HandleInput(string input)
        {
            switch (input)
            {
                case "exit":
                case "quit":
                    {
                        Console.WriteLine("Bye!");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                    }
                case "last":
                    {
                        Console.WriteLine(stack.LastAnswer);
                        break;
                    }
                case "lastp":
                    {
                        Console.WriteLine(stack.LastExpression);
                        break;
                    }
                default:
                    if (!con.IsInputANewConst(input))
                    {

                        CheckInputPattern(input);
                        eval.EvaluateUserInput(exp.Value_1, exp.Value_2, exp.Operator);
                        if (exp.IsValidInput)
                        {
                            Console.WriteLine(string.Format("{0} {1}", AnswerPrefix(), eval.ResultFromEval));
                            stack.SetLastExpression(exp.Value_1, exp.Value_2, exp.Operator);
                            stack.SetLastAnswer(eval.ResultFromEval);
                        }
                        else
                        {
                            Console.WriteLine(ErrorMessages.InvalidFormat());
                        }
                    }
                    break;
            }
            PromptCounter++;
        }
    }
}
