using System;

namespace DesignPatterns.Behavioral.Interpreter
{
    public class Startup
    {
        static void Main(string[] args)
        {
            var processor = new ExpressionProcessor();
            processor.Variables.Add('x', 5);

            var result = processor.Calculate("1+2+3");
            Console.WriteLine($"1+2+3: {result}");

            var result2 = processor.Calculate("1+2+xy");
            Console.WriteLine($"1+2+xy: {result2}");

            var result3 = processor.Calculate("10-2-x");
            Console.WriteLine($"10-2-x: {result3}");
        }
    }
}
