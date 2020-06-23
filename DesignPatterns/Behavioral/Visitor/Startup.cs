using System;

namespace DesignPatterns.Behavioral.Visitor
{
    public class Startup
    {
        static void Main(string[] args)
        {
            var printer = new ExpressionPrinter();
            var expression = new MultiplicationExpression(
                new Value(5),
                new AdditionExpression(
                    new Value(2),
                    new Value(3)));

            printer.Visit(expression);

            Console.WriteLine(printer.ToString()); //5*(2+3)
        }
    }
}
