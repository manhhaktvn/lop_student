﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lop_student
{
    internal class Student
    {
       
            private int rollno;
            private string name;
            private static string college = "BBDIT";

            //constructor to initialize the variable
            public Student(int r, string n)
            {
                rollno = r;
                name = n;
            }

            //static method to change the value of static variable

            public static void Change()
            {
                college = "CODEGYM";
            }

            //method to display values
            public void Display()
            {
                Console.WriteLine(rollno + " " + name + " " + college);
            }
        }
    }

