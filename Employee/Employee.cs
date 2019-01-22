using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Employee
{
    public static int Count { get; private set; }

    public string FirstName { get; }
    public string LastName { get; }
    private decimal monthlySalary;

    public Employee(string firstName, string lastName, decimal monthlySalary)
    {
        FirstName = firstName;
        LastName = lastName;
        ++Count;
        MonthlySalary = monthlySalary;
        Console.WriteLine("Employee constructor: " +
            $"{FirstName} {LastName}; Count = {Count}");
    }

    public decimal MonthlySalary
    {
        get
        {
            return monthlySalary;
        }
        set
        {
            if(value >= 0M)
            {
                monthlySalary = value;
            }
        }
    }

    public override string ToString() =>
        $"{FirstName,-10} {LastName,-10} {MonthlySalary,10:C}";
}



