using System.Linq;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Repository
{
    public class RepositoryEmployeeHistory : RepositoryBase<EmployeeHistory>, IRepositoryEmployeeHistory
    {
        public RepositoryEmployeeHistory(IRepository repository)
            : base(repository)
        {

        }


        public EmployeeHistory GetByTeacherId(int id)
        {
            return Repository.Select<EmployeeHistory>().Where(x => x.EmployeeId == id).FirstOrDefault();
        }
    }
}
