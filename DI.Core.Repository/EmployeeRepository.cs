using DI.Core.IRepository;
namespace DI.Core.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public string Display()
        {
            return "Hello SKS employee";
        }
    }
}
