using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Repository
{
    public class RepositoryEmploymentStatus : RepositoryBase<EmploymentStatus>, IRepositoryEmploymentStatus
    {
        public RepositoryEmploymentStatus(IRepository repository) : base(repository)
        {

        }
    }
}
