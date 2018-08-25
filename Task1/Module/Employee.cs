﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Module
{
    public enum prof
    {
        klerk, manager, boss
    }
    public struct Employee : IEmployee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime DateOfStart { get; set; }
        public int Salary { get; set; }
        public prof prof { get; set; }

        public Employee(string Name, int Age, DateTime DateOfStart, int Salary, prof prof)
        {
            this.Name = Name;
            this.Age = Age;
            this.DateOfStart = DateOfStart;
            this.Salary = Salary;
            this.prof = prof;
        }
        public override string ToString()
        {
            string str;
            str = string.Format("{0} ({1}) - {2} ({3}) \t{4}KZT",
                Name, Age, prof, DateOfStart, Salary);
            return str;
        }
    }
}
