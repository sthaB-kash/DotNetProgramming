using System;

namespace lab4
{
  class TestProgram
  {
    static void Main(string[] args)
    {
      Manager manager = new Manager();
      manager.display();
      SalesAssociate sa = new SalesAssociate();
      sa.display();
    }
  }
}
