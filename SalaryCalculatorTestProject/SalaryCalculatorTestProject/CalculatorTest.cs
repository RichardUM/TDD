using System;
using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SalaryCalculatorTestProject
{ 

  [TestClass]
  public class CalculatorTest
  {
      /*
       * To get hourly, divide annual salary by 2080
       * $100,006.40 / 2080 = 48.08 hr
       *
       * To get annual, multiply hourly by 2080
       * $48.08 * 2080 = $100,006.40
       *
       */
  
    [TestMethod] 
    public void AnnualSalaryTest()
    {
      //Arrange
      SalaryCalculator sc = new SalaryCalculator();

      //Act
      decimal annualSalary = sc.GetAnnualSalary(50);

      //Assert
      Assert.AreEqual(104000,annualSalary);
    }
  }
}
