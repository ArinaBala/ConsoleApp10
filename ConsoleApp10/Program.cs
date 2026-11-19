using System;
namespace ConsoleApp10
{
    

    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Firm[] firms =
            {
            new Firm
            {
                Name = "Global Food",
                FoundationDate = DateTime.Now.AddYears(-4),
                BusinessProfile = "Маркетинг",
                DirectorFullName = "John White",
                EmployeesCount = 150,
                Address = "London, Baker St",
                Employees = new[]
                {
                    new Employee { FullName = "Lionel Messi", Position = "Менеджер", Phone = "234-56-78", Email = "di.messi@food.com", Salary = 4500 },
                    new Employee { FullName = "Anna Smith", Position = "Аналитик", Phone = "555-12-34", Email = "anna@food.com", Salary = 3200 }
                }
            },
            new Firm
            {
                Name = "White Star IT",
                FoundationDate = DateTime.Now.AddDays(-123),
                BusinessProfile = "IT",
                DirectorFullName = "Robert Black",
                EmployeesCount = 250,
                Address = "New York, 5th Ave",
                Employees = new[]
                {
                    new Employee { FullName = "Lionel Richie", Position = "Разработчик", Phone = "239-00-11", Email = "lionel@it.com", Salary = 5000 },
                    new Employee { FullName = "Diana Prince", Position = "Менеджер", Phone = "987-65-43", Email = "diana@it.com", Salary = 4200 }
                }
            }
        };

            Task1.Run(firms);
            Task2.Run(firms);
            Task3.Run(firms);
        }
    }
}
