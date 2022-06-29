using System;

namespace dotnet_hello_world {
    class Factorial {
        public long fact(int num) {
            if(num <= 0 )
                return 1;
            else {
                // long rel = 1;
                // while(num != 0) {
                //     rel *= num;
                //     num --;
                // }
                // return rel;
                return num * fact(num -1); //using recursive function
            }
        }
    }
}