using System;
using System.Collections.Generic;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Program p = new Program();
            p.VariablesTest();

            List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 123, 567, 123, 78, 16, 723, 10, 135, 2, 46, 78 };
            p.HomeWork(nums);
        }

        /**************************************************************************************
                       HOMEWORK
        **************************************************************************************/

        public void HomeWork(List<int> numbers)
        {
            System.Console.WriteLine("\n HOMEWORK \n");
            System.Console.WriteLine("This is the solution");

            int sum = 0;
            // 1 - print the sum of all numbers
            // solve here
            foreach (int num in numbers)
            {
                sum += num;
            }
            System.Console.WriteLine("\n Sum: " + sum);


            // 2 - print Only even numbers ( % )
            System.Console.WriteLine("\n Even Numbers");
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    System.Console.WriteLine(num);
                }
            }

        }
        void VariablesTest()
        {
            //declare variables
            //type name = val
            string firstName = "Leticia";
            int age = 27;
            decimal total = 99.99m; //for money
            float f = 13.231f; //anything else
            bool found = false;

            System.Console.WriteLine("Math Operations");
            System.Console.WriteLine(age - 1);
            System.Console.WriteLine(age + 1);
            System.Console.WriteLine(age * 32);
            System.Console.WriteLine(age / 2);
            System.Console.WriteLine(age % 2); //modulos operator

            // for loop
            for (int i = 0; i < 10; i++)
            {
                // skip 3 and 7
                if (i != 3 && i != 7)  //if i not equal to 3 and i not equal to 7
                {
                    Console.WriteLine(i);
                }
            } //end for

            // array
            string[] name = new string[100];
            name[0] = "Wes";
            name[1] = "Lety";
            name[2] = "Keny";
            name[3] = "Lane";
            name[4] = "Ebbonai";

            //List

            List<string> lastName = new List<string>();
            lastName.Add("Somethings");
            lastName.Add("Another");
            lastName.Add("Smith");
            lastName.Add("Inzunza");
            lastName.Add("Stuff");

            //length of a list
            System.Console.WriteLine(lastName.Count);

            // iterate over a list
            for (int i = 0; i < lastName.Count; i++)
            {
                System.Console.WriteLine(lastName[i]);
            }

            // loop
            foreach (string last in lastName)
            {
                System.Console.WriteLine(last);
            }
        }
        /**
        string VariablesTest()
        {
            int age = 21; //ask the user for the value
            if (age < 20)
            {
                Console.WriteLine("its younger");
                return "yes";
            }
            else
            {
                Console.WriteLine("its getting old");
                return "no";
            }
        }
        */
    }
}