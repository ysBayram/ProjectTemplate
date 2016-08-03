using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Repository
{
   public class RepositoryTraineeEmploymentStatusField:RepositoryBase<TraineeEmploymentStatusField>,IRepositoryTraineeEmploymentStatusField
    {
        public RepositoryTraineeEmploymentStatusField(IRepository repository) : base(repository)
        {
        }
    }
}
