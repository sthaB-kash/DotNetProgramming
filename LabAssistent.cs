using System;

namespace lab_5 {
  public class LabAssistant:Employee {
    public LabAssistant(int id, string name, double sal):base(id:id, name:name, salary_per_day:sal){

    }
    public override double calc_salary() {
      return this.salary_per_day *30;
    }
  }
}