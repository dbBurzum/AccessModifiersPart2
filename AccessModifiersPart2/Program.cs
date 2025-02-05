﻿using System;
using AccessModifiersPart2.Models;

namespace AccessModifiersPart2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int StdCount = GetInputCount("How many studens do you have? ", 1, 10);

            Student[] Student = new Student[StdCount];
            for (int i = 0; i < StdCount; i++)
            {
                string Name = GetInputStr("Enter student name: ", 3, 30, 1);
                string Surname = GetInputStr("Enter student surname: ", 3, 35, 1);
                int Age = GetInputAge("Enter student age: ", 17, 65);
                int Point = GetInputPoints("Enter student point: ", 0, 100);

                Console.WriteLine($"Student profile {i+1} is created");
                Console.WriteLine("=========================");

                Student[i] = new Student(Name, Age, Surname, Point);

             
            }
            foreach (Student item in Student)
            {
                item.StdInfo();
            }


        }
        static string GetInputStr(string name, int min, int max, int up)
        {
            string input;
            

            do
            {
                Console.Write(name);
                input = Console.ReadLine();
                input.ToCharArray();
                for (int i = 0; i < 1; i++)
                {
                    if (Char.IsUpper(input[0]) == true){
                        up = 2;
                        
                    }
                    else
                    {
                        Console.WriteLine("First letter must be written in uppercase");
                    }
                }

            } while ( input.Length < min || input.Length > max || up!=2);
            
            return input;
        }
        static int GetInputCount(string name, int min, int max = int.MaxValue)
        {
            int input;
            do
            {
                Console.Write(name);
                input = Convert.ToInt32(Console.ReadLine());
                if (input<1 || input>10)
                {
                    Console.WriteLine("You must have at least 1 and maximum 10 students");
                }
            } while (input < min || input > max);
            return input;
        }

        static int GetInputAge(string name, int min = int.MinValue, int max = int.MaxValue)
        {
            int input;
            do
            {
                Console.Write(name);
                input = Convert.ToInt32(Console.ReadLine());
                if (input < 17 || input > 65)
                {
                    Console.WriteLine("Students must be older than 16, and younger than 66 ");
                }

            } while (input < min || input > max);
            return input;
        }
        static int GetInputPoints(string name, int min = int.MinValue, int max = int.MaxValue)
        {
            int input;
            do
            {
                Console.Write(name);
                input = Convert.ToInt32(Console.ReadLine());
                if (input < 0 || input > 100)
                {
                    Console.WriteLine("0 is the minimum points and 100 is the maximum");
                }
            } while (input < min || input > max);
            return input;
        }
    }
}
