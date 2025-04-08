// derived class(child) that inherits the employee class
public class Manager : Employee
{
    private double _bonus; // Manage Bonus (private)

    // Constructor call the constructor of the base class
    public Manager(string name, double salary, double bonus) : base(name, salary)
    {
        _bonus = bonus;
    }

    // Method to obtain the bonus of manage
    public double GetBonus()
    {
        return _bonus;
    }

    // Method to show the information of the manager (including the bonus)
    public void DisplayDataAndBonus()
    {
        Console.WriteLine($"Nome: {GetName()}, Salary: {GetSalary():C}, Bonus: {_bonus:C}");
    }
}