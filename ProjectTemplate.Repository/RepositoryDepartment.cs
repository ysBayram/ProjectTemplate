using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Repository
{
    public class RepositoryDepartment : RepositoryBase<Department>, IRepositoryDepartment
    {
        public RepositoryDepartment(IRepository repository)
            : base(repository)
        {
        }
    }
}