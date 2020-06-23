namespace DesignPatterns.Structural.Adapter
{
    public class SquareToRectangleAdapter : IRectangle
    {
        public int Width { get; }

        public int Height { get; }

        public SquareToRectangleAdapter(Square square)
        {
            Width = square.Side;
            Height = square.Side;
        }
    }
}
