using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    public class Firm
    {
        public string Name { get; set; }
        public DateTime FoundationDate { get; set; }
        public string BusinessProfile { get; set; }
        public string DirectorFullName { get; set; }
        public int EmployeesCount { get; set; }
        public string Address { get; set; }
        public Employee[] Employees { get; set; } = new Employee[0];

        public override string ToString()
        {
            return $"{Name} | {BusinessProfile} | Директор: {DirectorFullName} | Штат: {EmployeesCount} | {Address}";
        }
    }
}
