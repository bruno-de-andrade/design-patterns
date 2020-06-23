namespace DesignPatterns.Behavioral.Visitor
{
    public class AdditionExpression : Expression
    {
        public Expression LHS { get; }

        public Expression RHS { get; }

        public AdditionExpression(Expression lhs, Expression rhs)
        {
            LHS = lhs;
            RHS = rhs;
        }

        public override void Accept(ExpressionVisitor expressionVisitor)
        {
            expressionVisitor.Visit(this);
        }
    }
}
