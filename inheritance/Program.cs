using System;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Employee
    {
        public string name { get; set; }
        public int salary;
        public DateTime hire_date { get; set; }

        public Employee(string name, int salary)
        {
            this.name = name;
            this.salary = salary;
        }
        public virtual void get_salary()
        {
            Console.WriteLine(salary);
        }
    }
    class Engineer : Employee
    {
        public Engineer(string name, int salary) : base(name, salary)
        {
            Console.WriteLine("Hello");
        }
        public override void get_salary()
        {
            Console.WriteLine("Sorry this Employee's salary is private");
        }
    }
}
