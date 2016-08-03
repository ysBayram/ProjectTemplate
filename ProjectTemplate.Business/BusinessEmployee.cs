using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Business
{
  public class BusinessTeacher: BusinessBase<Employee>, IBusinessEmployee
    {
        private readonly IRepositoryEmployee _repositoryTeacher;

        public BusinessTeacher(IRepositoryBase<Employee> repositoryBase, IUnitOfWork uow, IRepositoryEmployee repositoryTeacher) : base(repositoryBase, uow)
        {
            _repositoryTeacher = repositoryTeacher;
        }

        public string GetFullName(Employee entity)
        {
            return _repositoryTeacher.GetFullName(entity);
        }
    }
}
