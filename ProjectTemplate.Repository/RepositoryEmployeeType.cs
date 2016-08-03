using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Repository
{
    public class RepositoryEmployeeType : RepositoryBase<EmployeeType>, IRepositoryEmployeeType
    {
        public RepositoryEmployeeType(IRepository repository)
            : base(repository)
        {
        }
    }
}