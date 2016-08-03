using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Service;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Service
{
    public class ServiceEducation : ServiceBase<Education>, IServiceEducation
    {
        private readonly IBusinessEducation _businessEducation;

        public ServiceEducation(IBusinessBase<Education> businessBase, IBusinessEducation businessEducation)
            : base(businessBase)
        {
            _businessEducation = businessEducation;
        }
    }
}
