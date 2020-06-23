using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Interpreter
{
    public class ExpressionProcessor
    {
        public Dictionary<char, int> Variables = new Dictionary<char, int>();

        public int Calculate(string expression)
        {
            var tokens = Lex(expression);
            return Parse(tokens).Value;
        }

        private List<Token> Lex(string expression)
        {
            var result = new List<Token>();

            for (int index = 0; index < expression.Length; index++)
            {
                switch (expression[index])
                {
                    case '+':
                        result.Add(new Token(TokenType.Plus, "+"));
                        break;
                    case '-':
                        result.Add(new Token(TokenType.Minus, "-"));
                        break;
                    default:
                        if (!int.TryParse(expression[index].ToString(), out _))
                        {
                            result.Add(new Token(TokenType.Variable, expression[index].ToString()));
                            break;
                        }

                        var sb = new StringBuilder(expression[index].ToString());

                        for (int j = index + 1; j < expression.Length; j++)
                        {
                            if (char.IsDigit(expression[j]))
                            {
                                sb.Append(expression[j]);
                                index++;
                            }
                            else
                            {
                                break;
                            }
                        }

                        result.Add(new Token(TokenType.Integer, sb.ToString()));
                        break;
                }
            }

            return result;
        }

        private IElement Parse(IReadOnlyList<Token> tokens)
        {
            var operation = new BinaryOperation();
            bool haveLHS = false;

            for (int index = 0; index < tokens.Count; index++)
            {
                var token = tokens[index];

                switch (token.TokenType)
                {
                    case TokenType.Variable:
                        if (Variables.TryGetValue(char.Parse(token.Text), out int value))
                        {
                            haveLHS = SetOperationValues(operation, new Integer(value), haveLHS);
                        }
                        else
                        {
                            return new Integer(0);
                        }

                        break;

                    case TokenType.Integer:
                        haveLHS = SetOperationValues(operation, new Integer(int.Parse(token.Text)), haveLHS);
                        break;

                    case TokenType.Plus:
                        if (operation.Right != null)
                        {
                            operation.Left = new Integer(operation.Value);
                            operation.Right = null;
                        }

                        operation.OperationType = OperationType.Addition;
                        break;

                    case TokenType.Minus:
                        if (operation.Right != null)
                        {
                            operation.Left = new Integer(operation.Value);
                            operation.Right = null;
                        }

                        operation.OperationType = OperationType.Subtraction;
                        break;
                }
            }

            return operation;
        }

        private bool SetOperationValues(BinaryOperation operation, Integer integer, bool haveLHS)
        {
            if (!haveLHS)
            {
                operation.Left = integer;
                haveLHS = true;
            }
            else
            {
                operation.Right = integer;
            }

            return haveLHS;
        }
    }
}
