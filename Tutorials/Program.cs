using System;
using System.Collections.Generic;

namespace Tutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            //NumbersInC();
            //BranchesAndLoops();
            //ListCollections();
            StringProgram();
        }
        static void NumbersInC()
        {
            
            double doublemin = double.MinValue;
            double doublemax = double.MaxValue;
            Console.WriteLine($"The range of the double type is {doublemin} to {doublemax}");

            decimal min = decimal.MinValue;
            decimal max = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {min} to {max}");

            double a = 1.0;
            double b = 3.0;
            Console.WriteLine(a / b);

            decimal c = 1.0M;
            decimal d = 3.0M;
            Console.WriteLine(c / d);

            //pi * r2
            double radius = 2.5;
            double circumference = Math.PI * radius;
            double area = Math.PI * radius * radius;

            Console.WriteLine("Radius = " + radius);
            Console.WriteLine("Circumference = " + circumference);
            Console.WriteLine("Area = " + area);
        }
        static void BranchesAndLoops()
        {
            int counter = 0;
            while (counter < 10)
            {

                Console.WriteLine("while "+counter);
                counter++;
            }

            int counterDo = 0;
            do
            {
                Console.WriteLine("do " +counterDo);
                counterDo++;
            } while (counterDo < 10);
            
            for (int counterFor = 0; counterFor < 10; counterFor++)
            {
                Console.WriteLine("for "+counterFor);
            }

            //print all numbers < 20 that are modulo 3
            int result;
            for (int counterLoop = 1; counterLoop <=20; counterLoop++)
            {
                result = counterLoop % 3;
                if (result == 0)
                {
                    Console.WriteLine(counterLoop + " has modulo" + result);
                }

            }
        }

        static void ListCollections()
        {
            var names = new List<string> { "<name>", "huub", "karin" };
            foreach (var v in names)
            {
                Console.WriteLine(v.ToUpper());
            }
        }



        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public Person(string first, string last)
            {
                FirstName = first;
                LastName = last;
            }

            public override string ToString()
            {
                return FirstName + " " + LastName;
            }

            public string AllCaps()
            {
                return ToString().ToUpper();
            }
        }
        public static void StringProgram()
        {
            var p = new Person("Bill", "Wagner");
            Console.WriteLine("The name, in all caps: " + p.AllCaps());
            Console.WriteLine("The name: " + p);
        }

   
        
    }
}
