using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Service;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Service
{
    public class ServiceTraineeEmploymentStatus : ServiceBase<TraineeEmploymentStatus>, IServiceTraineeEmploymentStatus
    {
        private readonly IBusinessTraineeEmploymentStatus _businessStudentWorkStateDetail;

        public ServiceTraineeEmploymentStatus(IBusinessBase<TraineeEmploymentStatus> businessBase, IBusinessTraineeEmploymentStatus businessStudentWorkStateDetail)
            : base(businessBase)
        {
            _businessStudentWorkStateDetail = businessStudentWorkStateDetail;
        }

        
    }
}
