using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Repository
{
    public class RepositoryBranch : RepositoryBase<Branch>, IRepositoryBranch
    {
        public RepositoryBranch(IRepository repository):base(repository)
        {
        }
    }
}
