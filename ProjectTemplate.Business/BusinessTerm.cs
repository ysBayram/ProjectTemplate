using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Business
{
    public class BusinessTerm : BusinessBase<Term>, IBusinessTerm
    {
        private readonly IRepositoryTerm _repositoryTerm;

        public BusinessTerm(IRepositoryBase<Term> repositoryBase, IUnitOfWork uow, IRepositoryTerm repositoryTerm)
            : base(repositoryBase, uow)
        {
            _repositoryTerm = repositoryTerm;
        }
    }
}