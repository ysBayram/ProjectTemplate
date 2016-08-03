using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Repository
{
    public class RepositoryCity : RepositoryBase<City>, IRepositoryCity
    {
        public RepositoryCity(IRepository repository): base(repository)
        {
        }
    }
}