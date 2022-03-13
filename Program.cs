using System;

namespace lab4
{
  class TestProgram
  {
    static void Main(string[] args)
    {
      // Manager manager = new Manager();
      // SalesAssociate sa = new SalesAssociate();
      // sa.display();


      Manager manager = new Manager(102, "Ram", "Prasad", "1959-12-19", "2022-03-05", 7580, 500, 50);
      manager.display();
      Manager manager1 = new Manager(103, "Shyam", "Prasad", "2004-12-09", "2022-01-05", 5600, 0, 0);
      manager1.display();

      SalesAssociate sa = new SalesAssociate(34, "Gita", "Devi", "2004-12-09", "2022-01-05", 4300, 0, 0, 15);
      sa.display();
      sa.display_sales();
      Console.WriteLine("Sales Bonus: {0}", sa.sales_bonus());

      SalesAssociate sa1 = new SalesAssociate(34, "Sita", "Devi", "2004-12-09", "2022-01-05", 3400, 0, 0, 5);
      sa1.display();
      sa1.display_sales();
      Console.WriteLine("Sales Bonus: {0}", sa1.sales_bonus());

      // Customer customer = new Customer();
      // Console.WriteLine(customer.ToString() + ": " + );
    }
  }
}
