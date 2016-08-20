using SimpleCalculator.Operations;

namespace SimpleCalculator
{
    public class Evaluator
    {
        Stack stack = new Stack();

        public string ResultFromEval { get; private set; }

        public void EvaluateUserInput(int v1, int v2, char op)
        {
            stack.SetLastExpression(v1, v2, op);
            switch (op)
            {
                case '+':
                    Add add = new Add();
                    ResultFromEval = add.Operate(v1, v2);
                    break;

                case '-':
                    Subtract sub = new Subtract();
                    ResultFromEval = sub.Operate(v1, v2);
                    break;

                case '/':
                    Divide div = new Divide();
                    ResultFromEval = div.Operate(v1, v2);
                    break;

                case '*':
                    Multiply mul = new Multiply();
                    ResultFromEval = mul.Operate(v1, v2);
                    break;

                case '%':
                    Modulus mod = new Modulus();
                    ResultFromEval = mod.Operate(v1, v2);
                    break;

                default:
                    break;
            }
        }
    }
}
