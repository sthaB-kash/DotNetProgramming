using System;

namespace lab_5
{
  class EmployeeTest
  {
    static void Main(string[] args)
    {
      LabAssistant la = new LabAssistant(5, "Bikash Shrestha", 600);
      la.display();
      Console.WriteLine("Salary/month: {0}", la.calc_salary());

      Console.WriteLine("``````````````````````````````````````");

      Lecturer lect = new Lecturer(12, "Ramesh Parajuli", 1500, 20);
      lect.display();
      Console.WriteLine("Salary/month: {0}", lect.calc_salary());

      Console.WriteLine("``````````````````````````````````````");

      Admin admin = new Admin(29, "Stha Bikash", 1800, 15);
      admin.display();
      Console.WriteLine("Salary/month: {0}", admin.calc_salary());

    }
  }
}
