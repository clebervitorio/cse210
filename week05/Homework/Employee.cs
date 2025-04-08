// Base Class (father)
public class Employee
{
    private string _name;  // Employee Name (private)
    private double _salary;  // Employee Salary (private)

    // Constructor to start the employee
    public Employee(string name, double salary)
    {
        _name = name;
        _salary = salary;
    }

    // Public Method to obtain the name (read-only)
    public string GetName()
    {
        return _name;
    }

    // Public Method to obtain the salary (read-only)
    public double GetSalary()
    {
        return _salary;
    }

    // Public Method to show the employees information
    public void DisplayData()
    {
        Console.WriteLine($"Name: {_name}, Salary: {_salary:C}");
    }
}