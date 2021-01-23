using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class TransportCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Transport Loan payment schedule calculated");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }

        
    }
}
