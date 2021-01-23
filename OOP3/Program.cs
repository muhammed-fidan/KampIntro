using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager personelCreditManager = new PersonalFinanceCredit();
            ICreditManager transportCreditManager = new TransportCreditManager();
            ICreditManager housingLoanManager = new HousingLoanManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            
            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.MakeAnApplication(transportCreditManager, fileLoggerService);

            List<ICreditManager> credits = new List<ICreditManager>() {personelCreditManager,transportCreditManager };
            //applicationManager.MakeCreditPreNotification(credits);
            
        }
    }
}
