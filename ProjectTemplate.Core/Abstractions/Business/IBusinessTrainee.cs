using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Core.Abstractions.Business
{
    public interface IBusinessTrainee : IBusinessBase<Trainee>, IGetFullName<Trainee>
    {
        
    }
}
