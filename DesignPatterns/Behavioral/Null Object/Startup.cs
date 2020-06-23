namespace DesignPatterns.Behavioral.NullObject
{
    public class Startup
    {
        static void Main(string[] args)
        {
            var nullLog = new NullLog();
            var account = new Account(nullLog);
            
            account.SomeOperation();
        }
    }
}
