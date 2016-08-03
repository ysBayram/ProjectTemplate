using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Service;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Service
{
    public class ServiceBranch : ServiceBase<Branch>, IServiceBranch
    {
        private readonly IBusinessBranch _businessBranch;

        public ServiceBranch(IBusinessBase<Branch> businessBase, IBusinessBranch businessBranch)
            : base(businessBase)
        {
            _businessBranch = businessBranch;
        }
    }
}
