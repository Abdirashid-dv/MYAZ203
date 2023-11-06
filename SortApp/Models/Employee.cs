namespace SortApp.Models;

public class Employee : IComparable, ICloneable
{

    #region default
    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public double Salary { get; set; }

    public override string ToString()
    {
        return $"{FirstName,-10} {LastName,-10} {Salary:C}";
    }
    #endregion

    public int CompareTo(object? obj)
    {
        var other = (Employee?)obj;
        // return this.Salary.CompareTo(other?.Salary);
	// if(this.Salary<other.Salary)
	// 	return 1;
	// else if (this.Salary == other.Salary)
	// 	return 0;
	// else:
	// 	return -1;

        return this.FirstName.CompareTo(other.FirstName);

    }

    public object Clone()
    {
        Employee newEmployee = new Employee();
        newEmployee.FirstName = this.FirstName;
        newEmployee.LastName = this.LastName;
        newEmployee.Salary = this.Salary;

        return newEmployee;
    }
}
