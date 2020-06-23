using System;

namespace DesignPatterns.Behavioral.Interpreter
{
    public class BinaryOperation : IElement
    {
        public OperationType OperationType;

        public IElement Left, Right;

        public BinaryOperation()
        {
            Left = new Integer(0);
            Right = new Integer(0);
        }

        public int Value
        {
            get
            {
                return OperationType switch
                {
                    OperationType.Addition => Left.Value + Right.Value,

                    OperationType.Subtraction => Left.Value - Right.Value,

                    _ => throw new ArgumentOutOfRangeException()
                };
            }
        }
    }
}
