namespace DesignPatterns.Structural.Decorator
{
    public class Startup
    {
        static void Main(string[] args)
        {
            var dragon = new Dragon { Age = 5 };
            dragon.Fly();
            dragon.Crawl();
        }
    }
}
