using DI.Core.IRepository;
using DI.Services.Contract;
namespace DI.Services
{
   public class EmployeeService : IEmployeeService
    {
        public IEmployeeRepository _repository;
        public EmployeeService(IEmployeeRepository repository)
        {
            _repository = repository;
        }
       public string Display()
        {
            return _repository.Display();
        }
    }
}
