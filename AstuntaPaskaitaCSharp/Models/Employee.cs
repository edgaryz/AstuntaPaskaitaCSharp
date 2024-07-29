using AstuntaPaskaitaCSharp.Contracts;

namespace AstuntaPaskaitaCSharp.Models
{
    public class Employee : IEmployee
    {
        protected string Name { get; set; }
        protected int Age { get; set; }

        public Employee() { }
        public Employee(string name, int age)
        {
            Name = name;
            Age = age;

        }

        public List<Employee> ReadData()
        {
            List<Employee> employees = new List<Employee>();

            using (StreamReader sr = new StreamReader("employees.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] values = line.Split(',');
                    if (values.Length == 2)
                    {
                        employees.Add(new Employee(values[0], int.Parse(values[1])));
                        Console.WriteLine("Employees reader here");
                        Console.WriteLine(values[0] + " " + values[1]);
                    }
                }
            }

            return employees;
        }

        public void WriteData(Employee employee)
        {
            using (StreamWriter sw = new StreamWriter("employees.txt", true))
            {
                sw.WriteLine($"{employee.Name},{employee.Age}");
            }
        }
    }
}
