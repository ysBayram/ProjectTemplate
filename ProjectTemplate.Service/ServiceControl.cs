using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Service;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Service
{
   public class ServiceControl: ServiceBase<ControlEnt>, IServiceControl
    {
        private readonly IBusinessControl _businessControl;

        public ServiceControl(IBusinessBase<ControlEnt> businessBase, IBusinessControl businessControl)
            : base(businessBase)
        {
            _businessControl = businessControl;
        }
    }
}
