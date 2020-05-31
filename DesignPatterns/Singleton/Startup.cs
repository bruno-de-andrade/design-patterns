using Autofac;
using System;

namespace DesignPatterns.Singleton
{
    class Startup
    {
        static void Main(string[] args)
        {
            // Basic singleton class
            Console.WriteLine($"Is Singleton? {SingletonTester.IsSingleton(() => SimpleSingletonDatabase.Instance)}");

            // Class not singleton by itself but by dependency injection
            var builder = new ContainerBuilder();
            builder.RegisterType<OrdinaryDatabase>().As<IDatabase>().SingleInstance();
            var container = builder.Build();

            Console.WriteLine($"Is Singleton? {SingletonTester.IsSingleton(() => container.Resolve<IDatabase>())}");
        }
    }
}
