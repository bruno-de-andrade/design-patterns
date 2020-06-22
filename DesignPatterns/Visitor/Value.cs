namespace DesignPatterns.Visitor
{
    public class Value : Expression
    {
        public readonly int ResultValue;

        public Value(int value)
        {
            ResultValue = value;
        }

        public override void Accept(ExpressionVisitor expressionVisitor)
        {
            expressionVisitor.Visit(this);
        }
    }
}
