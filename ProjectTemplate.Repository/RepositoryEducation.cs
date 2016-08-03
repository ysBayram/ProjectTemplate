using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Repository
{
    public class RepositoryEducation : RepositoryBase<Education>, IRepositoryEducation
    {
        public RepositoryEducation(IRepository repository):base(repository)
        {
        }
    }
}
