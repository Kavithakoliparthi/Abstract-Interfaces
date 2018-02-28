using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log4netDemo
{
    abstract class BaseEmployee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public abstract int GetMonthlySalary();
        
    }
}
