using System.Collections.Generic;
using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Service;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Service
{
    public class ServiceJobInterview : ServiceBase<JobInterview>, IServiceJobInterview
    {
        private readonly IBusinessJobInterview _businessInterview;

        public ServiceJobInterview(IBusinessBase<JobInterview> businessBase, IBusinessJobInterview businessInterview)
            : base(businessBase)
        {
            _businessInterview = businessInterview;
        }

        public ICollection<JobInterview> GetLastInterviews(Trainee student, int count)
        {
            return _businessInterview.GetLastInterviews(student, count);
        }
    }
}