using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log4netDemo
{
    interface Test1
    {
        void Square(int a);
    }
    interface Test2
    {
        void Cube(int a);
    }
    class Sample3 : Test1, Test2
    {
        static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public void Square(int a)
        {
            log.Info("The Square of a is:" + (a * a));

        }

        public void Cube(int a)
        {
            log.Info("The cube of a is:" + (a * a * a));
        }
        static void Main(string[] args)
        {
            Sample3 obj = new Sample3();
            obj.Square(8);
            obj.Cube(10);
            Console.ReadLine();
        }

      
    }
}
