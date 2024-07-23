using System;

namespace _4._11._Employee
{
    public class Employee
    {
        private string name;
        private decimal salary;
        private decimal bonus;

        public string Name
        {
            get { return name; }
        }

        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public Employee(string name, decimal salary)
        {
            this.name = name;
            this.salary = salary;
        }

        public virtual void SetBonus(decimal bonus)
        {
            this.bonus = bonus;
        }

        public decimal ToPay()
        {
            return salary + bonus;
        }
        public class SalesPerson : Employee
        {
            private int percent;

            public SalesPerson(string name, decimal salary, int percent) : base(name, salary)
            {
                this.percent = percent;
            }

            public override void SetBonus(decimal bonus)
            {
                if (percent > 200)
                {
                    base.SetBonus(bonus * 3);
                }
                else if (percent > 100)
                {
                    base.SetBonus(bonus * 2);
                }
                else
                {
                    base.SetBonus(bonus);
                }
            }
            public class Company
            {
                private Employee[] employees;

                public Company(Employee[] employees)
                {
                    this.employees = employees;
                }

                public void GiveEverybodyBonus(decimal companyBonus)
                {
                    foreach (var employee in employees)
                    {
                        employee.SetBonus(companyBonus);
                    }
                }

                public decimal TotalToPay()
                {
                    decimal total = 0;
                    foreach (var employee in employees)
                    {
                        total += employee.ToPay();
                    }
                    return total;
                }

                public (string name, decimal salary)[] GetNameSalary()
                {
                    var result = new (string name, decimal salary)[employees.Length];
                    for (int i = 0; i < employees.Length; i++)
                    {
                        result[i] = (employees[i].Name, employees[i].ToPay());
                    }
                    return result;
                }
            }
            public class Program
            {
                public static void Main(string[] args)
                {
                    Employee emp1 = new SalesPerson("Nina", 50000, 150);
                    Employee emp2 = new SalesPerson("Kate", 60000, 120);
                    Employee emp3 = new SalesPerson("Tom", 45000, 220);
                    Employee emp4 = new SalesPerson("Niki", 70000, 90);

                    Company company = new Company(new Employee[] { emp1, emp2, emp3, emp4 });

                    company.GiveEverybodyBonus(1000);

                    Console.WriteLine("Total to pay: " + company.TotalToPay());

                    var nameSalaries = company.GetNameSalary();
                    foreach (var nameSalary in nameSalaries)
                    {
                        Console.WriteLine($"Name: {nameSalary.name}, Salary with bonus: {nameSalary.salary}");
                    }
                }
            }



        }
    }
}

