using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log4netDemo
{
    class CalculationDemo : CalDemo
    {
        static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public override void Add(int x, int y)
        {
            log.Info("The addition of two numbers"+(x+y));
        }
        public override void Sub(int x, int y)
        {
            log.Info("The Subtraction of two numbers:" + (x - y));
        }
        static void Main(string[] args)
        {
            CalculationDemo obj = new CalculationDemo();
            obj.Mul(5, 8);
            obj.Add(20, 6);
            Console.ReadLine();
        }
    }
}