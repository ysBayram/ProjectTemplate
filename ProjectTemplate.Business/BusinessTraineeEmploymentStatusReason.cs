using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Business
{
    public class BusinessTraineeEmploymentStatusReason : BusinessBase<TraineeEmploymentStatusReason>, IBusinessTraineeEmploymentStatusReason
    {
        private readonly IRepositoryTraineeEmploymentStatusReason _repositoryStudentWorkStateReason;

        public BusinessTraineeEmploymentStatusReason(IRepositoryBase<TraineeEmploymentStatusReason> repositoryBase, IUnitOfWork uow, IRepositoryTraineeEmploymentStatusReason repositoryTraineeEmploymentStatusReason)
            : base(repositoryBase, uow)
        {
            _repositoryStudentWorkStateReason = repositoryTraineeEmploymentStatusReason;
        }
    }
}
