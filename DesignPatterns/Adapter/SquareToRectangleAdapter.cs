namespace DesignPatterns.Adapter
{
    public class SquareToRectangleAdapter : IRectangle
    {
        public SquareToRectangleAdapter(Square square)
        {
            Width = square.Side;
            Height = square.Side;
        }

        public int Width { get; }

        public int Height { get; }
    }
}
