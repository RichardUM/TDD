using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class SalaryCalculator
    {
      const int HourInYear = 2080;
      public decimal GetAnnualSalary(decimal hourlyWage) => hourlyWage * HourInYear;
      
      public decimal GetHourlyWage(int annualSalary) => annualSalary/HourInYear;
    }
}
