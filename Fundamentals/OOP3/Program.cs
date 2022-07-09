using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICredyManager educationCredyManager = new EducationCredyManager();
            ICredyManager houseCredyManager = new HouseCredyManager();

            ILoggerService loggerService1 = new DataBaseLoggerService();
            ILoggerService loggerService2 = new FileLoggerService();
            ILoggerService loggerService3 = new SmsLogger();

            List<ILoggerService> logServices = new List<ILoggerService>() { loggerService1,loggerService3 };

            ApplyManager applyManager = new ApplyManager();
            applyManager.Apply(houseCredyManager,logServices);

            List<ICredyManager> credities = new List<ICredyManager>() {houseCredyManager,educationCredyManager};
            //applyManager.CredyInfo(credities);
        }
    }
}
