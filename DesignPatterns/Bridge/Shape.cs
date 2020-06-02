namespace DesignPatterns.Bridge
{
    public class Shape
    {
        public string Name { get; set; }

        private readonly IRenderer _renderer;

        public Shape(IRenderer renderer)
        {
            _renderer = renderer;
        }

        public override string ToString()
        {
            return _renderer.Render(Name);
        }
    }
}
