using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Service;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Service
{
    public class ServiceState : ServiceBase<EmploymentStatus>, IServiceEmploymentStatus
    {
        private readonly IBusinessEmploymentStatus _businessState;

        public ServiceState(IBusinessBase<EmploymentStatus> businessBase, IBusinessEmploymentStatus businessState) : base(businessBase)
        {
            _businessState = businessState;
        }
    }
}
