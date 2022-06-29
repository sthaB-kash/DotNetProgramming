using System;
using System.Collections;
using System.Collections.Generic;

namespace dotnet_hello_world {

    class Cube {}
    class Test {
        public void greeting() {
            Console.WriteLine("Hello! Good Looking Stranger..");
        }

        public void boxing_and_unboxing() {
            Object obj = 6;
            Console.WriteLine("{0}: {1}",obj, obj);
            int val = (int)obj + 5;
            Console.WriteLine("{0}: {1}", val, val);

            Object str = "bikash";
            Console.WriteLine("{0}", (string)str + " shrestha");
            Console.WriteLine(str+ "shrestha");
        }
        
        public void dynamic_example() {
            List<object> mixedList = new List<object>();
            mixedList.Add("first group");
            mixedList.Add(4);
            mixedList.Add(67.5);
            mixedList.Add('c');
            Console.WriteLine("--------List-----------");
            foreach(var item in mixedList) {
                Console.WriteLine("{0}: {1}", item.GetType(), item);
            }

            Console.WriteLine("-----------Object---------------");
            // Storing different types of variables/values on Object
            // GetType().Name  -> returns the type of the variable 
            
            foreach( Object obj in new Object[] {"Bikash", 1999, "Shrestha", 7, 8}) {
                Console.WriteLine("{0}: {1}", obj.GetType().Name, obj);

            }

            int i = 0;
            // Prints True for any value of i
            Console.WriteLine(i.GetType() == typeof(int));

            Console.WriteLine("------------ArrayList-----------");
            
            // -------- HOW TO FIND IF A VARIABLE IS OF A CERTAIN TYPE? ---------//
            // You can use the keywords: "is" and "as"

            // .....1º Method..... //

            ArrayList myArray = new ArrayList();   // Class ArrayList. It creates a mutable array of objects of different types

            myArray.Add("Hello");
            myArray.Add(12);
            myArray.Add('+');
            myArray.Add(10);
                    
            int myVariable = 0;
                    
            foreach(object obj in myArray){     // You can use "var" instead of "object" 
                        
                if(obj is int)                          // You use the "is" keyword
                    myVariable += Convert.ToInt32(obj); // You need to convert the variable objet to what it contains for the compiler to accept this operation  
            
                if(obj is string)
                    Console.WriteLine(obj + " World");
            }
                        
            Console.WriteLine(myVariable);



            // .....2º Method.... //

            // Cube myTest = myVariable as Cube;   // Where Cube is a class named "Cube" and I want to know if myVariable is of type Cube 

            // if(myTest == null){
            // Console.WriteLine("MyVariable it's not a Cube!"); 
            // }
            // else {
            // Console.WriteLine("MyVariable is a Cube!");
            // }
        }
    }
}

