using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Business
{
    public class BusinessTraineeStatus : BusinessBase<TraineeStatus>, IBusinessTraineeStatus
    {
        private readonly IRepositoryTraineeStatus _repositoryInterviewState;

        public BusinessTraineeStatus(IRepositoryBase<TraineeStatus> repositoryBase, IUnitOfWork uow, IRepositoryTraineeStatus repositoryInterviewState)
            : base(repositoryBase, uow)
        {
            _repositoryInterviewState = repositoryInterviewState;
        }
    }
}
