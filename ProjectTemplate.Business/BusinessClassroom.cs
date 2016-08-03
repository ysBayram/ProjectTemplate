using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Business
{
    public class BusinessClassroom : BusinessBase<Classroom>, IBusinessClassroom
    {
        private readonly IRepositoryClassroom _repositoryClassroom;

        public BusinessClassroom(IRepositoryBase<Classroom> repositoryBase, IUnitOfWork uow, IRepositoryClassroom repositoryClassroom)
            : base(repositoryBase, uow)
        {
            _repositoryClassroom = repositoryClassroom;
        }
    }
}