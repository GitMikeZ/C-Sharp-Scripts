using System;
using System.Linq;

class LINQWithArrayOfObjects
{
    static void Main()
    {
        var employees = new[] {
            new Employee("Jason", "Red", 5000M),
            new Employee("Ashley", "Green", 7600M),
            new Employee("Matthew", "Indigo", 3587.5M),
            new Employee("James", "Indigo", 4700.77M),
            new Employee("Luke", "Indigo", 6200M),
            new Employee("Jason", "Blue", 3200M),
            new Employee("Wendy", "Brown", 4236.4M)
        };

        Console.WriteLine();

        //display all employees
        foreach (var element in employees)
        {
            Console.WriteLine(element);
        }

        //use LINQ to query expressions
        var between4K6K =
            from e in employees
            where (e.MonthlySalary >= 4000M) && (e.MonthlySalary <= 6000M)
            select e;

        // display employees making between 4000 and 6000 per month
        Console.WriteLine("\nEmployees earning in the range" + $"{4000:C}-{6000:C} per month:");
        foreach(var element in between4K6K)
        {
            Console.WriteLine(element);
        }

        var nameSorted =
            from e in employees
            orderby e.LastName, e.FirstName
            select e;

        Console.WriteLine("\nFirst employee when sorted by name:");

        if(nameSorted.Any())
        {
            Console.WriteLine(nameSorted.First());
        }
        else
        {
            Console.WriteLine("not found");
        }

        var lastNames =
            from e in employees
            select e.LastName;

        Console.WriteLine("\nUnique employee last names:");

        foreach(var element in lastNames.Distinct())
        {
            Console.WriteLine(element);
        }

        var names =
            from e in employees
            select new { e.FirstName, e.LastName };

        Console.WriteLine("\nNames only:");
        foreach(var element in names)
        {
            Console.WriteLine(element);
        }

        Console.WriteLine();

        employees = null;
    }
}


