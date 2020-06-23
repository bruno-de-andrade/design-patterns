namespace DesignPatterns.Structural.Adapter
{
    public static class ExtensionMethods
    {
        public static int GetArea(this IRectangle retangle)
        {
            return retangle.Width * retangle.Height;
        }
    }
}
