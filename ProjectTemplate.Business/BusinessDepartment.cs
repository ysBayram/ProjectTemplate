using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Business
{
    public class BusinessDepartment : BusinessBase<Department>, IBusinessDepartment
    {
        private readonly IRepositoryDepartment _repositoryDepartment;

        public BusinessDepartment(IRepositoryBase<Department> repositoryBase, IUnitOfWork uow, IRepositoryDepartment repositoryDepartment)
            : base(repositoryBase, uow)
        {
            _repositoryDepartment = repositoryDepartment;
        }
    }
}