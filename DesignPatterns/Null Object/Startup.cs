using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Null_Object
{
    class Startup
    {
        static void Main(string[] args)
        {
            var nullLog = new NullLog();
            var account = new Account(nullLog);
            
            account.SomeOperation();
        }
    }
}
