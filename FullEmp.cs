
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log4netDemo
{
    class FullTimeEmployee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public int AnnualSalary { get; set; }
        public int GetMonthlySalary()
        {
            return this.AnnualSalary / 12;
        }
    }
    class PartTimeEmployee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public int TotalHours { get; set; }
        public int HourlyPay { get; set; }
        public int GetMonthlySalary()
        {
            return this.TotalHours * HourlyPay;
        }
    }
    class FullEmp
    {
        static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            FullTimeEmployee obj = new FullTimeEmployee();
            obj.Id = 103;
            obj.FirstName = "anusha";
            obj.AnnualSalary = 60000;

            log.Info("The monthly salary for full time meployee is:"+obj.GetMonthlySalary());

            PartTimeEmployee obj1 = new PartTimeEmployee();
            obj1.Id = 103;
            obj1.FirstName = "anusha";
            obj1.TotalHours = 60;
            obj1.HourlyPay = 200;
            log.Info("The monthly salary for part time employee is:" + obj1.GetMonthlySalary());
            Console.ReadLine();
        }
    }
}
