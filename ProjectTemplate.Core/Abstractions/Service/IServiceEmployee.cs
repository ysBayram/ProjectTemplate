using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Core.Abstractions.Service
{
 
    public interface IServiceEmployee : IServiceBase<Employee>, IGetFullName<Employee>
    {
    }
}
