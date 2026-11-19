using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{ 
    public static class Task1
    {
        public static void Run(Firm[] firms)
        {
            Console.WriteLine("1");

            
            var all = from f in firms select f;

            var withFood = from f in firms
                           where f.Name.Contains("Food")
                           select f;

          
            var marketing = from f in firms
                            where f.BusinessProfile == "Маркетинг"
                            select f;

            
            var marketingOrIt = from f in firms
                                where f.BusinessProfile == "Маркетинг" || f.BusinessProfile == "IT"
                                select f;

            var more100 = from f in firms
                          where f.EmployeesCount > 100
                          select f;

           
            var range100To300 = from f in firms
                                where f.EmployeesCount >= 100 && f.EmployeesCount <= 300
                                select f;

           
            var london = from f in firms
                         where f.Address.Contains("London")
                         select f;

           
            var directorWhite = from f in firms
                                where f.DirectorFullName.EndsWith("White")
                                select f;

            
            var older2Years = from f in firms
                              where f.FoundationDate < DateTime.Now.AddYears(-2)
                              select f;

            
            var days123 = from f in firms
                          where (DateTime.Now.Date - f.FoundationDate.Date).Days == 123
                          select f;

            var blackAndWhite = from f in firms
                                where f.DirectorFullName.EndsWith("Black") && f.Name.Contains("White")
                                select f;

            Print("Фирмы со словом Food:", withFood);
            Print("Директор Black и слово White в названии:", blackAndWhite);
        }

        private static void Print(string title, IEnumerable<Firm> list)
        {
            Console.WriteLine($"\n{title}");
            foreach (var item in list)
                Console.WriteLine("  " + item);
        }
    }
}
