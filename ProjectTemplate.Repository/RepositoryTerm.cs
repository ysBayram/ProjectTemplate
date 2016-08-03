using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Repository
{
    public class RepositoryTerm : RepositoryBase<Term>, IRepositoryTerm
    {
        public RepositoryTerm(IRepository repository)
            : base(repository)
        {
        }
    }
}