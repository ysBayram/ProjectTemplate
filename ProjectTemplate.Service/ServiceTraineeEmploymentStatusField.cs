using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Service;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Service
{
   public class ServiceTraineeEmploymentStatusField: ServiceBase<TraineeEmploymentStatusField>, IServiceTraineeEmploymentStatusField
    {
        private readonly IBusinessTraineeEmploymentStatusField _businessStudentWorkStateField;

        public ServiceTraineeEmploymentStatusField(IBusinessBase<TraineeEmploymentStatusField> businessBase, IBusinessTraineeEmploymentStatusField businessStudentWorkStateField)
            : base(businessBase)
        {
            _businessStudentWorkStateField = businessStudentWorkStateField;
        }

    }
}
