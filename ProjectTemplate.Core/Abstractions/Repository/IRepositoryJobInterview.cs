using System.Collections.Generic;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Core.Abstractions.Repository
{
    public interface IRepositoryJobInterview : IRepositoryBase<JobInterview>
    {
        ICollection<JobInterview> GetInterviewsByStudent(Trainee student);
    }
}