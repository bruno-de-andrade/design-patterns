namespace DesignPatterns.Structural.Bridge
{
    public class VectorRenderer : IRenderer
    {
        public string Render(string shapeName)
        {
            return $"Drawing {shapeName} as lines";
        }
    }
}
