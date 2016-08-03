using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Business
{
    public class BusinessEducation : BusinessBase<Education>, IBusinessEducation
    {
        private readonly IRepositoryEducation _repositoryEducation;

        public BusinessEducation(IRepositoryBase<Education> repositoryBase, IUnitOfWork uow, IRepositoryEducation repositoryEducation)
            : base(repositoryBase, uow)
        {
            _repositoryEducation = repositoryEducation;
        }
    }
}
