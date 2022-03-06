using System;
using System.Collections;

namespace lab_3
{
  class Q5
  {
    public void getInputs()
    {
      var dcaList = new ArrayList();
      Console.WriteLine("Enter 5 debtors, creditors, and credit amount in CSV: ");
      for(int i=0; i<5; i++)
      {
        Console.Write("#CSV data-{0}: ", i+1);
        string data = Console.ReadLine();
        dcaList.Add(separate_csv_data(data));
      }
      // for(int i = 0; i<dcaList.Count; i++)
      // {
      //   Console.WriteLine(dcaList[i]);
      // }

      // foreach(ArrayList dca in dcaList)
      // {
      //   string dc = (string)dca[0]+(string)dca[1];
      //   for(int i=1; i<dcaList.Count; i++)
      //   {
      //     if(String.Equals(dc,(string)dcaList[i][0]+(string)dcaList[i][1]))
      //   }
      // }
      foreach(ArrayList item in dcaList)
      {
        foreach(var subitem in item)
        {
          Console.Write(subitem + " ");
        }
        Console.WriteLine();
      }
    }

    private ArrayList separate_csv_data(string data)
    {
      string[] arr = data.Split(',');
      var dataList = new ArrayList();
      foreach(string str in arr)
      {
        dataList.Add(str);
      }
      return dataList;
    }
  }
}