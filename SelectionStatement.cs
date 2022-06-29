using System;

namespace dotnet_hello_world {
    class SelectionStatement {
        public void example() {
            int val = 5;
            if(val == 0) {
                Console.WriteLine("Sunday");
            }else if(val == 1) 
                Console.WriteLine("Monday");
            else if(val == 2) Console.WriteLine("Tuesday");
            else if(val == 3) Console.WriteLine("Wednesday");
            else if(val == 4) Console.WriteLine("Thursday");
            else if(val == 5) Console.WriteLine("Friday");
            else if(val == 6) Console.WriteLine("Saturday");
            else Console.WriteLine("--invalid input--");
            //switch
            int day = val;
            switch(day+1)
            {
                case 0: 
                    Console.WriteLine("Sunday"); 
                    break;
                case 1: 
                    Console.WriteLine("Monday"); 
                    break;
                case 2: 
                    Console.WriteLine("Tuesday"); 
                    break;
                case 3: 
                    Console.WriteLine("Wednesday"); 
                    break;
                case 4: 
                    Console.WriteLine("Thursday"); 
                    break;
                case 5: 
                    Console.WriteLine("Friday"); 
                    break;
                case 6: 
                    Console.WriteLine("Saturday"); 
                    break;
                default:
                    Console.WriteLine("--invalid input--");
                    break;
            }
        }
    }
}