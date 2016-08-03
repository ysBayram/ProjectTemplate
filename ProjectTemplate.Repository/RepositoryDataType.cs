
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Repository
{
   public class RepositoryDataType: RepositoryBase<DataTypeEnt>,IRepositoryDataType
    {
        public RepositoryDataType(IRepository repository)
            : base(repository)
        {

        }
    }
}
