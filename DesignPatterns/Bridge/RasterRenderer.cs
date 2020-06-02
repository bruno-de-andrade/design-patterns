namespace DesignPatterns.Bridge
{
    class RasterRenderer : IRenderer
    {
        public string Render(string shapeName)
        {
            return $"Drawing {shapeName} as pixels";
        }
    }
}
