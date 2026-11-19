using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    public class Employee
    {
        public string FullName { get; set; }
        public string Position { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }

        public override string ToString()
        {
            return $"{FullName} ({Position}) — Тел: {Phone}, Email: {Email}, ЗП: {Salary}";
        }
    }
}
