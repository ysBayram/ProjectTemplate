using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Core.Abstractions.Service
{
    public interface IServiceTrainee : IServiceBase<Trainee>, IGetFullName<Trainee>
    {
        
    }
}
