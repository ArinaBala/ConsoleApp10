using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp10
{
    public static class Task3
    {
        public static void Run(Firm[] firms)
        {
            Console.WriteLine("\n3");

            var firmEmployees = firms
                .Where(f => f.Name == "Global Food")
                .SelectMany(f => f.Employees);

            var highSalary = firms
                .Where(f => f.Name == "Global Food")
                .SelectMany(f => f.Employees)
                .Where(e => e.Salary > 4000);

            var managers = firms
                .SelectMany(f => f.Employees)
                .Where(e => e.Position == "Менеджер");

            var phone23 = firms
                .SelectMany(f => f.Employees)
                .Where(e => e.Phone.StartsWith("23"));

            var emailDi = firms
                .SelectMany(f => f.Employees)
                .Where(e => e.Email.StartsWith("di"));

            var lionels = firms
                .SelectMany(f => f.Employees)
                .Where(e => e.FullName.StartsWith("Lionel "));

            Print("Все сотрудники Global Food:", firmEmployees);
            Print("Все менеджеры:", managers);
            Print("Телефон начинается с 23:", phone23);
            Print("Email начинается с di:", emailDi);
            Print("Сотрудники с именем Lionel:", lionels);
        }

        private static void Print(string title, IEnumerable<Employee> list)
        {
            Console.WriteLine($"\n{title}");
            foreach (var item in list)
                Console.WriteLine("  " + item);
        }
    }
}
