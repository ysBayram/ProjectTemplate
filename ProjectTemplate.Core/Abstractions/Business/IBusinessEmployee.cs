using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Core.Abstractions.Business
{
    public interface IBusinessEmployee : IBusinessBase<Employee>, IGetFullName<Employee>
    {
    }
}
