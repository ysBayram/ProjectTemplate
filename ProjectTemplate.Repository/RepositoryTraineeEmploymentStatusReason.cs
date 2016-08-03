using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Repository
{
    public class RepositoryTraineeEmploymentStatusReason : RepositoryBase<TraineeEmploymentStatusReason>, IRepositoryTraineeEmploymentStatusReason
    {
        public RepositoryTraineeEmploymentStatusReason(IRepository repository)
            : base(repository)
        {
        }
    }
}
