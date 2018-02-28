using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log4netDemo
{
    class PartTimeEmp : BaseEmployee
    {
        public int TotalHours { get; set; }
        public int HourlyPay { get; set; }
        public override int GetMonthlySalary()
        {
            return this.TotalHours * HourlyPay;
        }
    }
}
