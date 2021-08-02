using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciples.Dependency_Inversion_Principle
{
    public interface ISalaryCalculator
    {
        float CalculateSalary(int hoursWorked, float hourlyRate);
    }

    public class SalaryCalculator : ISalaryCalculator
    {
        public float CalculateSalary(int hoursWorked, float hourlyRate) => hoursWorked * hourlyRate;
    }

    public class EmployeeDetails
    {
        private readonly ISalaryCalculator _salaryCalculator;
        public int HoursWorked { get; set; }
        public int HourlyRate { get; set; }
        public EmployeeDetails(ISalaryCalculator salaryCalculator)
        {
            _salaryCalculator = salaryCalculator;
        }
        public float GetSalary()
        {
            return _salaryCalculator.CalculateSalary(HoursWorked, HourlyRate);
        }
    }

}