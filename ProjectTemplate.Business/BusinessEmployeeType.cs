using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Business
{
    public class BusinessEmployeeType : BusinessBase<EmployeeType>, IBusinessEmployeeType
    {
        private readonly IRepositoryEmployeeType _repositoryEmployeeType;

        public BusinessEmployeeType(IRepositoryBase<EmployeeType> repositoryBase, IUnitOfWork uow, IRepositoryEmployeeType repositoryEmployeeType)
            : base(repositoryBase, uow)
        {
            _repositoryEmployeeType = repositoryEmployeeType;
        }
    }
}