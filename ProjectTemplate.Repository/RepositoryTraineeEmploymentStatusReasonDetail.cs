using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Repository
{
    public class RepositoryTraineeEmploymentStatusReasonDetail : RepositoryBase<TraineeEmploymentStatusReasonDetail>, IRepositoryTraineeEmploymentStatusReasonDetail
    {
        public RepositoryTraineeEmploymentStatusReasonDetail(IRepository repository)
            : base(repository)
        {
        }
    }
}
