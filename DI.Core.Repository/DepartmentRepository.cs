using DI.Core.IRepository;
namespace DI.Core.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        public string GetDepartment()
        {
            return "Hello SKS Depaartment";
        }
    }
}
