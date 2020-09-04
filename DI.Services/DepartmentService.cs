using DI.Core.IRepository;
using DI.Services.Contract;
namespace DI.Services
{
    public class DepartmentService : IDepartmentService
    {
       public IDepartmentRepository _repository;
        public DepartmentService(IDepartmentRepository repository)
        {
            _repository = repository;
        }
        public string GetDepartment()
        {
            return _repository.GetDepartment();
        }
    }
}
