using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log4netDemo
{
    interface Sample2
    {
        void Add(int a, int b);
        void Sub(int a, int b);
    }
    class ImplmentationCls : Sample2
    {
        static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public void Add(int a,int b)
        {
            log.Info("The Addition of two numbers:" + (a + b));
        }
        public void Sub(int a,int b)
        {
            log.Info("The Subtraction of two numbers:" + (a - b));
        }
        static void Main(string[] args)
        {
            ImplmentationCls obj = new ImplmentationCls();
            obj.Add(2,8);
            obj.Sub(13,6);
            Console.ReadLine();
        }
    }
}
