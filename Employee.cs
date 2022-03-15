using System;

namespace lab_5
{
  public abstract class Employee
  {
    protected int id;
    string name;
    protected double salary_per_day;

    public Employee(int id, string name, double salary_per_day)
    {
      this.id = id;
      this.name = name;
      this.salary_per_day = salary_per_day;
    }
    public virtual void display()
    {
      Console.WriteLine("Employee Details: {0} \nName: {1}\nSalary/day: {2}", this.id, this.name, this.salary_per_day);
    }

    public abstract double calc_salary();
  }

}