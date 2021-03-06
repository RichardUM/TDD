﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Polymorphism;

namespace PolymorphismTestProject
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void CalculateWeeklySalaryForEmployeeTest_70wage55hoursReturns2800Dollars()
    {
      //Arrange
      int weeklyHours = 55;
      int wage = 70;
      int salary = 40 * wage;
      
      Employee e = new Employee();
      string expectedR = $"This ANGRY EMPLOYEE worked {weeklyHours} hrs. " +
                         $"Paid for 40 hrs at $ {wage}" + 
                         $"/hr = ${salary}";

      string response = e.CalculateWeeklySalary(weeklyHours, wage);
      //Assert
      Assert.AreEqual(response, expectedR);
    }
    
    [TestMethod]
    public void CalculateWeeklySalaryForContractore55hoursReturns3850Dollars()
    {
      int weeklyHours = 55;
      int wage = 70;
      int salary = weeklyHours* wage;

      Contractor e = new Contractor();

      string expRes = $"This HAPPY CONTRACTOR worked {weeklyHours} hrs." +
                      $"Paid for {weeklyHours} hrs at {wage} " +
                      $"/hr = {salary}"; 

      string response = e.CalculateWeeklySalary(weeklyHours, wage);
      
      Assert.AreEqual(response,expRes);

    }

    [TestMethod]
    public void CalculateWeeklySalaryForEmployeeTest_70wage55hoursDoesNotReturnCorrectString()
    {
      //Arrange
      int weeklyHours = 55;
      int wage = 70;
      int salary = 40 * wage;

      Employee e = new Employee();
      string expectedR = $"P1 This ANGRY EMPLOYEE worked {weeklyHours} hrs. " +
                         $"Paid for 40 hrs at $ {wage}" +
                         $"/hr = ${salary}";
            //Act
            string response = e.CalculateWeeklySalary(weeklyHours, wage);
      //Assert
      Assert.AreNotEqual(response, expectedR);
    }

    [TestMethod]
    public void CalculateWeeklySalaryForContractorTest_70wag55hoursDoesNotReturnCorrectStrings()
    {
      int weeklyHours = 55;
      int wage = 70;
      int salary = weeklyHours * wage;

      Contractor e = new Contractor();

      string expRes = $"P2 This HAPPY CONTRACTOR worked {weeklyHours} hrs." +
                      $"Paid for {weeklyHours} hrs at {wage} " +
                      $"/hr = {salary}";

            string response = e.CalculateWeeklySalary(weeklyHours, wage);

      Assert.AreNotEqual(response,expRes);

    }
    }
}
