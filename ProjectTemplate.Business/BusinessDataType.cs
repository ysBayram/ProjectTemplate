using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Business
{
  public class BusinessDataType: BusinessBase<DataTypeEnt>, IBusinessDataType
    {
        private readonly IRepositoryDataType _repositoryDataType;

        public BusinessDataType(IRepositoryBase<DataTypeEnt> repositoryBase, IUnitOfWork uow, IRepositoryDataType repositoryDataType)
            : base(repositoryBase, uow)
        {
            _repositoryDataType = repositoryDataType;
        }
    }
}
