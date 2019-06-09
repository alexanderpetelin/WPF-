﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WPFPatternMVVM.Data
{
    class Person
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public static Person[] GetPersons() 
        {
            var result = new Person[]
            {
                new Person{LastName="Иванов",FirstName="Иван"},
                new Person{LastName="Петров",FirstName="Петр"}
            };
            return result;
        }
    }
}
