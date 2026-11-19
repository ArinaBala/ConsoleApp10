using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    public static class Task2
    {
        public static void Run(Firm[] firms)
        {
            Console.WriteLine("\n 2");

            
            var all = firms.Select(f => f);

            var withFood = firms.Where(f => f.Name.Contains("Food"));

            var marketing = firms.Where(f => f.BusinessProfile == "Маркетинг");

            var marketingOrIt = firms.Where(f => f.BusinessProfile == "Маркетинг" || f.BusinessProfile == "IT");

            var more100 = firms.Where(f => f.EmployeesCount > 100);

            var range100To300 = firms.Where(f => f.EmployeesCount >= 100 && f.EmployeesCount <= 300);

            var london = firms.Where(f => f.Address.Contains("London"));

            var directorWhite = firms.Where(f => f.DirectorFullName.EndsWith("White"));

            var older2Years = firms.Where(f => f.FoundationDate < DateTime.Now.AddYears(-2));

            var days123 = firms.Where(f => (DateTime.Now.Date - f.FoundationDate.Date).Days == 123);

            var blackAndWhite = firms.Where(f => f.DirectorFullName.EndsWith("Black") && f.Name.Contains("White"));

            Print("От 100 до 300 сотрудников:", range100To300);
            Print("Основаны ровно 123 дня назад:", days123);
        }

        private static void Print(string title, IEnumerable<Firm> list)
        {
            Console.WriteLine($"\n{title}");
            foreach (var item in list)
                Console.WriteLine("  " + item);
        }
    }
}
