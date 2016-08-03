using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Business
{
  public  class BusinessTraineeEmploymentStatusField : BusinessBase<TraineeEmploymentStatusField>, IBusinessTraineeEmploymentStatusField
    {
        private readonly IRepositoryTraineeEmploymentStatusField _repositoryStudentWorkStateField;
        public BusinessTraineeEmploymentStatusField(IRepositoryBase<TraineeEmploymentStatusField> repositoryBase, IUnitOfWork uow, IRepositoryTraineeEmploymentStatusField repositoryStudentWorkStateField) : base(repositoryBase, uow)
        {
            _repositoryStudentWorkStateField = repositoryStudentWorkStateField;
        }
    }
}
