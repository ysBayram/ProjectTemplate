using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Service;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Service
{
    public class ServiceTerm : ServiceBase<Term>, IServiceTerm
    {
        private readonly IBusinessTerm _businessTerm;

        public ServiceTerm(IBusinessBase<Term> businessBase, IBusinessTerm businessTerm)
            : base(businessBase)
        {
            _businessTerm = businessTerm;
        }
    }
}