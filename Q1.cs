using System;

namespace lab4
{
  class Employee
  {
    protected int id;
    protected string fname, lname, dob, hire_date;
    protected float current_salary, bonus;
    protected int stock_options;

    public Employee()
    {
      Console.WriteLine("--------------------");
      Console.WriteLine("employee initialized");
      Console.WriteLine("--------------------");
    }

    public void display()
    {
      Console.WriteLine("ID: {0}\n" +
      "First Name: " + fname +
      "\nLast Name: " + lname +
      "\nDOB: " + dob +
      "\nHire Date: " + hire_date +
      "\nCurrent Salary: " + current_salary +
      "\nBonus: " + bonus +
      "\nStock Options: " + stock_options
      , id);
    }
  }

  class Manager : Employee
  {
    public Manager()
    {
      id = 5;
      fname = "Bikash";
      lname = "Shrestha";
      dob = "2000-02-22";
      hire_date = "2022-02-22";
      current_salary = 200000;
      bonus = 0;
      stock_options = 2;
    }
    public void setStockOptions(int options)
    {
      stock_options = options;
    }

    public int getStockOptions()
    {
      return stock_options;
    }

    public float calculateBonus()
    {
      return 0;
    }


  }

  class SalesAssociate : Employee
  {
    int no_of_sales;
    public SalesAssociate()
    {
      no_of_sales = 0;
    }

    public double sales_bonus()
    {
      double applicable_bonus_per = 0;

      if (no_of_sales > 10 && no_of_sales <= 20)
      {
        applicable_bonus_per = 0.05;
      }
      else if (no_of_sales > 20 && no_of_sales <= 30)
      {
        applicable_bonus_per = 0.2;
      }
      else if (no_of_sales > 30)
      {
        applicable_bonus_per = 0.3;
      }
      else
        applicable_bonus_per = 0;
      return no_of_sales * applicable_bonus_per;
    }
  }
}


