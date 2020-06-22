using System.Text;

namespace DesignPatterns.Visitor
{
    public class ExpressionPrinter : ExpressionVisitor
    {
        private readonly StringBuilder _sb = new StringBuilder();

        public override void Visit(Value value)
        {
            _sb.Append(value.ResultValue);
        }

        public override void Visit(AdditionExpression additionExpression)
        {
            _sb.Append("(");
            additionExpression.LHS.Accept(this);
            _sb.Append("+");
            additionExpression.RHS.Accept(this);
            _sb.Append(")");
        }

        public override void Visit(MultiplicationExpression multiplicationExpresion)
        {
            multiplicationExpresion.LHS.Accept(this);
            _sb.Append("*");
            multiplicationExpresion.RHS.Accept(this);
        }

        public override string ToString() => _sb.ToString();
    }
}
