using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Core.Abstractions.Repository
{
   
    public interface IRepositoryEmployee : IRepositoryBase<Employee>, IGetFullName<Employee>
    {
    }
}
