using System;

namespace lab4
{
  class Person
  {
    protected string name, address, phone;

    public Person()
    {
      name = "Bikash Shrestha";
      address = "Baishdhara, KTM";
      phone = "9865183709";
    }

  }

  class Customer : Person
  {
    int customer_no;
    string email;
    double purchase_amount;
    Boolean mailing;

    public Customer()
    {
      mailing = false;
      customer_no = 01;
      email = "shresthabikash2073@gmail.com";
      purchase_amount = 2000;
    }
  }
}