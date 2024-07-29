using AstuntaPaskaitaCSharp.Contracts;
using AstuntaPaskaitaCSharp.Models;

namespace MyProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            List<Employee> managers = new List<Employee>();

            IEmployee emp = new Employee();
            IEmployee man = new Manager();

            employees = emp.ReadData();
            managers = man.ReadData();

            emp.WriteData(new Employee("Cameron", 25));
            emp.WriteData(new Employee("Hobo", 24));
            emp.ReadData();
            man.WriteData(new Manager("Edgar", 28, 1));
            man.ReadData();
        }
    }
}