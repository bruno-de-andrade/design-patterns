using System;
using System.Numerics;

namespace DesignPatterns.Behavioral.Strategy
{
    public class QuadraticEquationSolver
    {
        private readonly IDiscriminantStrategy _strategy;

        public QuadraticEquationSolver(IDiscriminantStrategy strategy)
        {
            _strategy = strategy;
        }

        public Tuple<Complex, Complex> Solve(double a, double b, double c)
        {
            var discriminant = new Complex(_strategy.CalculateDiscriminant(a, b, c), 0);
            var plusResult = (-b + Complex.Sqrt(discriminant)) / 2 * a;
            var minusResult = (-b - Complex.Sqrt(discriminant)) / 2 * a;

            return new Tuple<Complex, Complex>(plusResult, minusResult);
        }
    }
}
