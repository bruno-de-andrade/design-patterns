﻿namespace DesignPatterns.Behavioral.NullObject
{
    public class NullLog : ILog
    {
        public int RecordLimit { get; } = int.MaxValue;

        public int RecordCount { get; set; } = default;

        public void LogInfo(string message)
        {
            RecordCount++;
        }
    }
}
