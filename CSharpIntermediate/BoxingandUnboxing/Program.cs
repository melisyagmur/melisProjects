using System;
using System.Collections.Generic;

namespace BoxingandUnboxing

{
    public class Boxing
        //converting valuye type to referance type
    {
        int number = 10; //STACK
        //object obj = number; //Static değil,classta kullanılamaz 
        object obj1 = 10; //boxed by clr and stored in heap. Creates an object in the heap, and 
        //referance in the stack.
        
       
    }

    class Program
    {
        static void Main(string[] args)
        {
            object obj = 10;
            int number = (int)obj; //Unboxing
        }
    }
}
