using System;
using System.Collections.Generic;

namespace StackExample
{
    public class Class1
    {
        static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>();

            numbers.Push(1);
            numbers.Push(2);
            numbers.Push(3);
            //since (last in, forst out) ang stack yung last push element(3)yun yung i pi print
            foreach (var number in numbers)
            {
                Console.WriteLine(number); // mag pi print ito starting sa taas pababa
            }
            Console.WriteLine("********ImissYou********");

            numbers.Pop(); // aalisin yung top element sa stack (number 3)  
                           // paka pop yung 2 ang matitira as the new top of the stack
            foreach (var number in numbers)
            {
                Console.WriteLine(number); // piprint yung stack pakatapos ng pop operation
            }
        }
    }
}
