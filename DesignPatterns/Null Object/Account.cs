using System;

namespace DesignPatterns.Null_Object
{
    public class Account
    {
        private readonly ILog _log;

        public Account(ILog log)
        {
            _log = log;
        }

        public void SomeOperation()
        {
            int count = _log.RecordCount;
            
            _log.LogInfo("Performing an operation");
            
            if (count + 1 != _log.RecordCount)
            {
                throw new Exception();
            }
                
            if (_log.RecordCount >= _log.RecordLimit)
            {
                throw new Exception();
            }
        }
    }
}
