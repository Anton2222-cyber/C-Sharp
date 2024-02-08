using System;
using System.Collections.Generic;
using System.Linq;

namespace Company
{
    class Company
    {
        public string Name { get; set; }
        public List<Division> divisions { get; set; }

        public void DivisionMaxSalary()
        {
            var res = divisions.Max(t => t.Unities.Sum(x => x.workers.Sum(a => a.Salary)));
            Division div = divisions.Where(t => t.Unities.Sum(x => x.workers.Sum(a => a.Salary)) == res).FirstOrDefault();
            Console.WriteLine("========================== Max salary of divisions ==========================");
            Console.WriteLine($"Division: {div.Name}");
            Console.WriteLine($"Salary: {res}");
        }

        public void DivisionAvgSalary()
        {

            Console.WriteLine("========================== Average salary of divisions ==========================");
            foreach (Division divv in divisions)
            {
                divv.AvgSalary();
            }
        }
        public void MaxSalaryOfUnities()
        {

            List<BusinessUnity> unities_all = new List<BusinessUnity>();
            foreach (Division div in divisions)
            {
                unities_all.Add(div.MaxSalary());
            }

            var res = unities_all.Max(x => x.workers.Sum(a => a.Salary));
            BusinessUnity unt = unities_all.Where(x => x.workers.Sum(a => a.Salary) == res).FirstOrDefault();
            Console.WriteLine("========================== Max salary of unity ==========================");
            Console.WriteLine($"Unity: {unt.Name}");
            Console.WriteLine($"Salary: {res}");
        }

        public void MinIntervalSalary()
        {
            int index = new int();
            List<int> intervals = new List<int>();
            foreach (Division div in divisions)
            {
                intervals.Add(div.Unities.Max(x => x.workers.Max(a => a.Salary)) - div.Unities.Min(x => x.workers.Min(a => a.Salary)));
            }
            for (int i = 0; i < intervals.Count; i++)
            {
                if (intervals.Min() == intervals[i])
                    index = i;
            }
            Console.WriteLine("========================== Min interval salary of divisions ==========================");
            Console.WriteLine($"Division: {divisions[index].Name}");
            Console.WriteLine($"Salary interval: {intervals.Min()}");
        }

        public void MansPercent()
        {
            Console.WriteLine("========================== Percent mans of workers ==========================");
            foreach (Division div in divisions)
            {
                div.MansPercent();
            }
        }
    }
    class Division
    {
        public List<BusinessUnity> Unities { get; set; }
        public string Name { get; set; }

        public void AvgSalary()
        {
            var res = Unities.Average(x => x.workers.Sum(a => a.Salary));
            Console.WriteLine($"{Name}: {Math.Round(res, 0)}");
        }
        public BusinessUnity MaxSalary()
        {
            var res = Unities.Max(x => x.workers.Sum(a => a.Salary));
            BusinessUnity unt = Unities.Where(x => x.workers.Sum(a => a.Salary) == res).FirstOrDefault();
            return unt;
        }
        public void MansPercent()
        {
            int count_workers = Unities.Sum(d => d.workers.Count);
            int res = Unities.Sum(s => s.workers.Where(a => a.Stat == "Male").Count());
            double percent = (Convert.ToDouble(res) / Convert.ToDouble(count_workers)) * 100;
            Console.WriteLine($"{Name}: {Math.Round(percent, 1)}%");
        }

    }
    class BusinessUnity
    {
        public List<Worker> workers { get; set; }
        public string Name { get; set; }
    }
    class Worker
    {
        public string FIO { get; set; }
        public int Salary { get; set; }
        public string Posada { get; set; }
        public string Stat { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Generator gnr = new Generator();
            Company company = new Company();
            company = gnr.GenerateCompany();
            company.DivisionMaxSalary();
            company.DivisionAvgSalary();
            company.MaxSalaryOfUnities();
            company.MinIntervalSalary();
            company.MansPercent();
        }
    }
}
