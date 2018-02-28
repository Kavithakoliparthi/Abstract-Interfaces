using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log4netDemo
{
    interface TransactionDemo
    {
        void showTransaction();
    }
    class Trans : TransactionDemo
    {
        private string TCode;
        private string TDate;
        private double TAmount;
        static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public Trans(string s1,string s2,double d1)
        {
            TCode = s1;
            TDate = s2;
            TAmount = d1;
        }
        public void showTransaction()
        {
            log.Info("The Transaction Code is:" + TCode);
            log.Info("The Transaction Date is:" + TDate);
            log.Info("The Transaction Amount is:" + TAmount);
        }
    }
    class Sample4
    {
        static void Main(string[] args)
        {
            Trans obj1 = new Trans("0012","25/02/18",2000);
            Trans obj2 = new Trans("0014", "18/01/18", 3000);
            Trans obj3 = new Trans("0015", "05/12/18", 5000);
            obj1.showTransaction();
            obj2.showTransaction();
            obj3.showTransaction();
            Console.ReadLine();
        }
    }
}
