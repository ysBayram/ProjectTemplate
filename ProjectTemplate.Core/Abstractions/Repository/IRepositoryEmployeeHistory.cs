using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Core.Abstractions.Repository
{
    public interface IRepositoryEmployeeHistory : IRepositoryBase<EmployeeHistory>
    {
        EmployeeHistory GetByTeacherId(int TeacherId);
    }
}