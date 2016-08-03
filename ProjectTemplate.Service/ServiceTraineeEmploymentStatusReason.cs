using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Service;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Service
{
    public class ServiceTraineeEmploymentStatusReason : ServiceBase<TraineeEmploymentStatusReason>, IServiceTraineeEmploymentStatusReason
    {
         private readonly IBusinessTraineeEmploymentStatusReason _businessStudentWorkStateReason;

         public ServiceTraineeEmploymentStatusReason(IBusinessBase<TraineeEmploymentStatusReason> businessBase, IBusinessTraineeEmploymentStatusReason businessStudentWorkStateReason)
            : base(businessBase)
        {
            _businessStudentWorkStateReason = businessStudentWorkStateReason;
        }
    }
}
