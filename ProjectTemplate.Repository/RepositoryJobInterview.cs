using System.Collections.Generic;
using System.Linq;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Repository
{
    public class RepositoryJobInterview : RepositoryBase<JobInterview>, IRepositoryJobInterview
    {
        public RepositoryJobInterview(IRepository repository)
            : base(repository)
        {

        }

        public ICollection<JobInterview> GetInterviewsByStudent(Trainee student)
        {
            return student.Interviews.OrderByDescending(x => x.Date).ToList();
        }
    }
}
