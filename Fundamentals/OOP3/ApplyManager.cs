using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplyManager
    {
        // Method injection
        public void Apply(ICredyManager credyManager,List<ILoggerService> loggerServices)
        {
            credyManager.Calc();

            foreach (var logService in loggerServices)
            {
                logService.Log();
            }
        }

        public void CredyInfo(List<ICredyManager> credities)
        {
            foreach (var credy in credities)
            {
                credy.Calc();
            }
        }
    }
}
