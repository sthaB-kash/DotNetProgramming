using System;

namespace lab_5
{
  public class Lecturer : Employee
  {

    double hra;
    // take percentage val of hra 
    public Lecturer(int id, string name, double sal, double hra_per) : base(id: id, name: name, salary_per_day: sal)
    {
      this.hra = hra_per / 100;
    }

    public override double calc_salary()
    {
      double bs = calc_bs();
      return bs + bs * hra;
    }

    double calc_bs()
    {
      return this.salary_per_day * 30;
    }
    public override void display()
    {
      base.display();
      Console.WriteLine("BS: {0}", calc_bs());
      Console.WriteLine("HRA: {0}%\n(Lecturer)", hra * 100);
    }
  }
}