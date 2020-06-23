namespace DesignPatterns.Behavioral.State
{
    public class CombinationLock
    {
        private readonly int[] _combination;

        public string Status { get; private set; } = "LOCKED";

        public CombinationLock(int[] combination)
        {
            _combination = combination;
        }

        public void EnterDigit(int digit)
        {
            if (Status == "LOCKED" || Status == "ERROR")
            {
                Status = string.Empty;
            }

            Status += digit;

            if (_combination[Status.Length - 1] != digit)
            {
                Status = "ERROR";
                return;
            }

            if (Status.Length == _combination.Length)
                Status = "OPEN";
        }
    }
}