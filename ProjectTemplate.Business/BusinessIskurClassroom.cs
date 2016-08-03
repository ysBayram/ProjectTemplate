using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Business
{
    public class BusinessIskurClassroom : BusinessBase<IskurClassroom>, IBusinessIskurClassroom
    {
        private readonly IRepositoryIskurClassroom _repositoryIskurClassroom;

        public BusinessIskurClassroom(IRepositoryBase<IskurClassroom> repositoryBase, IUnitOfWork uow, IRepositoryIskurClassroom repositoryIskurClassroom)
            : base(repositoryBase, uow)
        {
            _repositoryIskurClassroom = repositoryIskurClassroom;
        }
    }
}