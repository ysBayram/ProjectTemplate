using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Business
{
    public class BusinessTraineeEmploymentStatus : BusinessBase<TraineeEmploymentStatus>,IBusinessTraineeEmploymentStatus
    {
         private readonly IRepositoryTraineeEmploymentStatus _repositoryStudentWorkStateDetail;

         public BusinessTraineeEmploymentStatus(IRepositoryBase<TraineeEmploymentStatus> repositoryBase, IUnitOfWork uow, IRepositoryTraineeEmploymentStatus repositoryStudentWorkStateDetail):base(repositoryBase, uow)
        {
            _repositoryStudentWorkStateDetail = repositoryStudentWorkStateDetail;
        }
    }
}