using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log4netDemo
{
    abstract class CalDemo
    {
        static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public abstract void Add(int x, int y);
        public abstract void Sub(int x, int y);
        public void Mul(int x, int y)
        {
            log.Info("The Multiplication of x and y is:" + (x * y));
        }
    }
}
