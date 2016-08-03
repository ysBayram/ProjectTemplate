using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Repository
{
    public class RepositoryTraineeEmploymentStatus :RepositoryBase<TraineeEmploymentStatus>,IRepositoryTraineeEmploymentStatus
    {
        public RepositoryTraineeEmploymentStatus(IRepository repository):base(repository)
        {
           
            
        }
    }
}
