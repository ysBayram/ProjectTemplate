using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Business
{
    public class BusinessBranch : BusinessBase<Branch>, IBusinessBranch
    {
        private readonly IRepositoryBranch _repositoryBranch;

        public BusinessBranch(IRepositoryBase<Branch> repositoryBase, IUnitOfWork uow, IRepositoryBranch repositoryBranch)
            : base(repositoryBase, uow)
        {
            _repositoryBranch = repositoryBranch;
        }
    }
}
