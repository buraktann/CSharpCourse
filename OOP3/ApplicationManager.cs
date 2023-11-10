using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class ApplicationManager
    {
        //Method injection
        public void Apply(ICreditManager creditManager,List <ILoggerService> loggerServices)
        {
            //Başvuran bilgileri değerlendirme
            creditManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }

        }

        public void ProvideLoanPreNotification(List<ICreditManager>credits)
        {
            foreach (var credit in credits)
            {
                credit.Hesapla();
            }
        }

        
    }
}
