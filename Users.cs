﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreConsoleApplication
{
    internal class Users
    {
        private string name;
        private string companyName;
        private int age;

        private string City { get; set; }

        public Users()
        {
            companyName = "ABC";
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string CompanyName
        {
            get { return companyName; }

        }
        public int Age
        {
            get { return age; }
            set 
            {
                if (value < 18) throw new ArithmeticException("Invalid Age");
                age = value;
            }
        }
    }
}
