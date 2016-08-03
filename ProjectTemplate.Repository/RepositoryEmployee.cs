using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Repository
{
    
    public class RepositoryEmployee : RepositoryBase<Employee>, IRepositoryEmployee
    {
        public RepositoryEmployee(IRepository repository) : base(repository)
        {

        }

        public string GetFullName(Employee entity)
        {
            return entity.FirstName + " " + entity.LastName;
        }
    }
}
