using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Business
{
    public class BusinessTrainee:BusinessBase<Trainee>,IBusinessTrainee
    {
        private readonly IRepositoryTrainee _repositoryStudent;

        public BusinessTrainee(IRepositoryBase<Trainee> repositoryBase, IUnitOfWork uow, IRepositoryTrainee repositoryStudent):base(repositoryBase, uow)
        {
            _repositoryStudent = repositoryStudent;
        }


        public string GetFullName(Trainee entity)
        {
            return _repositoryStudent.GetFullName(entity);
        }
    }
}
