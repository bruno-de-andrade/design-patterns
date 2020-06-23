namespace DesignPatterns.Behavioral.Command
{
    public class Command
    {
        public Action Action { get; set; }

        public int Amount { get; set; }

        public bool Success { get; set; }
    }
}
