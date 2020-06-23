namespace DesignPatterns.Behavioral.Visitor
{
    public abstract class ExpressionVisitor
    {
        public abstract void Visit(Value expression);

        public abstract void Visit(AdditionExpression expression);

        public abstract void Visit(MultiplicationExpression expression);
    }
}
