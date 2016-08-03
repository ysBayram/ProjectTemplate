using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Service;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Service
{
    public class ServiceTraineeStatus : ServiceBase<TraineeStatus>, IServiceTraineeStatus
    {
        private readonly IBusinessTraineeStatus _businessInterviewState;

        public ServiceTraineeStatus(IBusinessBase<TraineeStatus> businessBase, IBusinessTraineeStatus businessInterviewState)
            : base(businessBase)
        {
            _businessInterviewState = businessInterviewState;
        }
    }
}
