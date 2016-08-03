using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Service;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Service
{
  public class ServiceTraineeEmploymentStatusReasonDetail:ServiceBase<TraineeEmploymentStatusReasonDetail>,IServiceTraineeEmploymentStatusReasonDetail
    {
        private readonly IBusinessTraineeEmploymentStatusReasonDetail _businessStudentWorkStateReasonRelation;

        public ServiceTraineeEmploymentStatusReasonDetail(IBusinessBase<TraineeEmploymentStatusReasonDetail> businessBase, IBusinessTraineeEmploymentStatusReasonDetail businessStudentWorkStateReasonRelation)
            : base(businessBase)
        {
            _businessStudentWorkStateReasonRelation = businessStudentWorkStateReasonRelation;
        }
    }
}
