﻿using NonPrimitiveType.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonPrimitiveType
{
    class Program
    {
        private static Person john;

        static void Main(string[] args)
        {
            // var john = new Person();
            // john.FirstName = "John";
            //  john.LastName = "Smith";
            // john.Introduce();
            // Calculator calculator = new Calculator();
            // var result = calculator.Add(1, 2);
            //  Console.WriteLine(result);
            var numbers = new int[3];

            // Arrays

            numbers[0] = 1;
            Console.WriteLine(numbers[0]);
             Console.WriteLine(numbers[1]);
             Console.WriteLine(numbers[2]);



            var flags = new bool[3];
            flags[0] = true;
            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            // objeect initialisation syntax
            var names = new string[3] { "Jack", "John", "Mary" };

            // string


            var names2 = new string[3] { "John", "Jack", "Mary" };
            var formatttedNames = string.Join(",", names2);
            Console.WriteLine(formatttedNames);

            //string firstName = "Kindeme";
            //string lastName = "Kounoudji";
            // string myFullName = string.Format("My name is {{0)} {{1}}",firstName,lastName);
            // Console.WriteLine(myFullName);

            

        }
    }
}
