﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiersPart2.Models
{
    internal class Person
    {
        private string _name;
        private int _age;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
             
            }
        }
        public int Age{ 
            get
            { 
               return _age;
            }
            set
            { 
            _age = value;
            }
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        


    }
}