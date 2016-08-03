using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Core.Abstractions.Repository
{
    public interface IRepositoryTrainee : IRepositoryBase<Trainee>, IGetFullName<Trainee>
    {
        
    }
}
