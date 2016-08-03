using System.Collections.Generic;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Core.Abstractions.Service
{
    public interface IServiceJobInterview : IServiceBase<JobInterview>
    {
        ICollection<JobInterview> GetLastInterviews(Trainee student, int count);
    }
}
