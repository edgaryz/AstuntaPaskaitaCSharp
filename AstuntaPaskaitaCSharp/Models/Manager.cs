using AstuntaPaskaitaCSharp.Contracts;

namespace AstuntaPaskaitaCSharp.Models
{
    public class Manager : Employee, IEmployee
    {
        protected int NumberOfEmployees { get; set; }
        public Manager() { }
        public Manager(string name, int age, int numberOfEmployees) : base(name, age)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public List<Employee> ReadData()
        {
            List<Employee> managers = new List<Employee>();

            using (StreamReader sr = new StreamReader("employees.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] values = line.Split(',');
                    if (values.Length == 3)
                    {
                        managers.Add(new Manager(values[0], int.Parse(values[1]), int.Parse(values[2])));
                        Console.WriteLine("Managers reader here");
                        Console.WriteLine(values[0] + " " + values[1] + " " + values[2]);
                    }
                }
            }

            return managers;
        }

        public void WriteData(Manager manager)
        {
            using (StreamWriter sw = new StreamWriter("employees.txt", true))
            {
                sw.WriteLine($"{manager.Name},{manager.Age},{manager.NumberOfEmployees}");
            }

        }
    }
}
