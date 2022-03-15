using System;

namespace lab_5
{
  class EmployeeTest
  {
    static void Main(string[] args)
    {
      LabAssistant la = new LabAssistant(5, "Bikash Shrestha", 600);
      la.display();
      Console.WriteLine("Salary: {0}", la.calc_salary());
    }
  }
}
