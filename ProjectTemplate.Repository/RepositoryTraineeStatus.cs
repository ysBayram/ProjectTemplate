using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Repository
{
    public class RepositoryTraineeStatus : RepositoryBase<TraineeStatus>, IRepositoryTraineeStatus
    {
        public RepositoryTraineeStatus(IRepository repository)
            : base(repository)
        {


        }
    }
}