using System;

namespace user_defined_exception
{
    class TempIsZeroException : Exception {
        public TempIsZeroException(string message) : base(message) {}
    }

    class Temperature {
        int temp = 0;
        public int Temp {
            get {
                return temp;
            }
            set {
                if (value == 0) {
                    throw new TempIsZeroException("Temperature is zero");
                }
                temp = value;
            }
        }
    }

    class Program
    {
        // static void Main(string[] args)
        // {
        //     Temperature obj = new Temperature();
        //     try {
        //         Console.Write("Enter temperature: ");
        //         obj.Temp = Convert.ToInt32(Console.ReadLine());
        //     } catch (TempIsZeroException e) {
        //         Console.WriteLine(e.Message);
        //     } finally {
        //         Console.WriteLine("Temperature: {0}", obj.Temp);
        //     }
        // }
    }
}