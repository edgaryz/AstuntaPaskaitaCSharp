using AstuntaPaskaitaCSharp.Models;

namespace AstuntaPaskaitaCSharp.Contracts
{
    public interface IEmployee
    {
        List<Employee> ReadData();
        void WriteData(Employee employee);
    }
}
