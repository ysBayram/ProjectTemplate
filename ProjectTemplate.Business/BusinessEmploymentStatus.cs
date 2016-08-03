using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Business
{
    public class BusinessState : BusinessBase<EmploymentStatus>, IBusinessEmploymentStatus
    {
        private readonly IRepositoryEmploymentStatus _repositoryState;
        public BusinessState(IRepositoryBase<EmploymentStatus> repositoryBase, IUnitOfWork uow, IRepositoryEmploymentStatus repositoryState) : base(repositoryBase, uow)
        {
            _repositoryState = repositoryState;
        }
    }
}
