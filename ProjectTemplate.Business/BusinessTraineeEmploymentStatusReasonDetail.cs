using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Business
{
    public class BusinessTraineeEmploymentStatusReasonDetail : BusinessBase<TraineeEmploymentStatusReasonDetail>, IBusinessTraineeEmploymentStatusReasonDetail
    {
         private readonly IRepositoryTraineeEmploymentStatusReasonDetail _repositoryTraineeEmploymentStatusReasonDetail;

         public BusinessTraineeEmploymentStatusReasonDetail(IRepositoryBase<TraineeEmploymentStatusReasonDetail> repositoryBase, IUnitOfWork uow, IRepositoryTraineeEmploymentStatusReasonDetail repositoryTraineeEmploymentStatusReasonDetail)
            : base(repositoryBase, uow)
        {
            _repositoryTraineeEmploymentStatusReasonDetail = repositoryTraineeEmploymentStatusReasonDetail;
        }
    }
}
