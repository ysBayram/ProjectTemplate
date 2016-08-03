using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Core.Abstractions.Service
{
    public interface IServiceEmployeeHistory : IServiceBase<EmployeeHistory>
    {
        EmployeeHistory GetByTeacherId(int TeacherId);
    }
}