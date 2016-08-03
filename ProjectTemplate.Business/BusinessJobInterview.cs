using System.Collections.Generic;
using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Business
{
    public class BusinessJobInterview : BusinessBase<JobInterview>, IBusinessJobInterview
    {
        private readonly IRepositoryJobInterview _repositoryInterview;

        public BusinessJobInterview(IRepositoryBase<JobInterview> repositoryBase, IUnitOfWork uow, IRepositoryJobInterview repositoryInterview)
            : base(repositoryBase, uow)
        {
            _repositoryInterview = repositoryInterview;
        }

        public ICollection<JobInterview> GetLastInterviews(Trainee student, int count)
        {
            List<JobInterview> listAllInterviews = (List<JobInterview>)_repositoryInterview.GetInterviewsByStudent(student);

            List<JobInterview> listLastInterviews = new List<JobInterview>();

            JobInterview emptyModel = new JobInterview()
            {
                Description = "", Date = null, Firm = new Firm() { Name = "" }, ModelType = 0
            };

            for (int i = 0; i < count; i++)
            {
                if (listAllInterviews.Count > i)
                {
                    listLastInterviews.Add(listAllInterviews[i]);
                }
                else
                {
                    listLastInterviews.Add(emptyModel);
                }
            }

            return listLastInterviews;
        }
    }
}