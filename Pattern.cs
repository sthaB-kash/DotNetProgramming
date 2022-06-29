using System;
using System.Collections;

namespace dotnet_hello_world {
    class Pattern {
        ArrayList primeNumbers(int from, int to) {
            ArrayList rel = new ArrayList();
            int num = from;
            while(num <= to) {
                if(isPrime(num)) rel.Add(num);
                num ++;
            }
            return rel;
        }

        bool isPrime(int num) {
            int count = 0;
            for(int i=1; i<=num; i++ ) {
                // Console.WriteLine("{0}, {1}, {2}, {3}\n-------------", num, i, num % i==0, count);
                if(num % i == 0 ) {
                    count ++;
                }
            }
            return count == 2;
        }

        public void printPattern(int from, int to) {
            ArrayList primeList = primeNumbers(from, to);
            Console.WriteLine(primeList.Count);
            // foreach(int num in primeList) {
            //     Console.Write("{0}, ", num);
            // }
            Console.WriteLine();
            int primeIndex = 0;
            for( int i=0; i<5; i++) {
                for(int j = 0; j<=i; j++) {
                    Console.Write("{0} ", (int)primeList[primeIndex++]);
                    
                }
                Console.WriteLine("\n");
            }
        }
    }
}