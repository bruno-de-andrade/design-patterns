namespace DesignPatterns.Bridge
{
    class VectorRenderer : IRenderer
    {
        public string Render(string shapeName)
        {
            return $"Drawing {shapeName} as lines";
        }
    }
}
