using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Core.Abstractions.Business
{
    public interface IBusinessEmployeeHistory : IBusinessBase<EmployeeHistory>
    {
        EmployeeHistory GetByTeacherId(int TeacherId);
    }
}
