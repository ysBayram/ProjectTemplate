using System.Collections.Generic;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Core.Abstractions.Business
{
    public interface IBusinessJobInterview : IBusinessBase<JobInterview>
    {
        ICollection<JobInterview> GetLastInterviews(Trainee student, int count);
    }
}