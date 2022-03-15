using System;

namespace lab_5 {
  public class Admin: Employee {
    double hra;
    public Admin(int id, string name, double sal, double hra):base(id: id, name: name, salary_per_day: sal) {
      this.hra = hra /100;
    }

    public override double calc_salary()
    {
      double bs = calc_bs();
      return bs + bs * hra;
    }

    public override void display()
    {
      base.display();
      Console.WriteLine("BS: {0}", calc_bs());
      Console.WriteLine("HRA: {0}%\n(Admin)", hra * 100);
    }
    double calc_bs() {
      return this.salary_per_day * 30;
    }
  }
}