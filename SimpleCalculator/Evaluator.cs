using System;

namespace SimpleCalculator
{
    public class Evaluator
    {
        public int ResultFromEval { get; private set; }
        public bool CannotEvaluate = false;

        public void EvaluateUserInput(int v1, int v2, char op)
        {
            Stack stack = new Stack();
            stack.SetLastExpression(v1, v2, op);
            switch (op)
            {
                case '+':
                    ResultFromEval = v1 + v2;
                    stack.SetLastAnswer(ResultFromEval);
                    break;

                case '-':
                    ResultFromEval = v1 - v2;
                    stack.SetLastAnswer(ResultFromEval);
                    break;

                case '/':
                    try
                    {
                        ResultFromEval = v1 / v2;
                        stack.SetLastAnswer(ResultFromEval);
                    }
                    catch (DivideByZeroException)
                    {
                        CannotEvaluate = true;
                        break;
                    }
                    break;

                case '*':
                    ResultFromEval = v1 * v2;
                    stack.SetLastAnswer(ResultFromEval);
                    break;

                case '%':
                    ResultFromEval = v1 % v2;
                    stack.SetLastAnswer(ResultFromEval);
                    break;

                default:
                    CannotEvaluate = true;
                    break;
            }
        }
    }
}
