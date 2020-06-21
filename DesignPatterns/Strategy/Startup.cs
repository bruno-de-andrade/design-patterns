using System;

namespace DesignPatterns.Strategy
{
    class Startup
    {
        static void Main(string[] args)
        {
            var solverOrdinaryStrategy = new QuadraticEquationSolver(new OrdinaryDiscriminantStrategy());
            var solverRealStrategy = new QuadraticEquationSolver(new RealDiscriminantStrategy());

            Console.WriteLine($"Ordinary strategy: {solverOrdinaryStrategy.Solve(1, 2, 3)}");
            Console.WriteLine($"Real strategy: {solverRealStrategy.Solve(1, 2, 3)}");
        }
    }
}
