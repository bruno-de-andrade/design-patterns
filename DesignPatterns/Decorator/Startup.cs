namespace DesignPatterns.Decorator
{
    class Startup
    {
        static void Main(string[] args)
        {
            var dragon = new Dragon { Age = 5 };
            dragon.Fly();
            dragon.Crawl();
        }
    }
}
