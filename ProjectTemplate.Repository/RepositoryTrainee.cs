using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Repository
{
    public class RepositoryTrainee : RepositoryBase<Trainee>, IRepositoryTrainee
    {
        public RepositoryTrainee(IRepository repository):base(repository)
        {
        }

        public string GetFullName(Trainee entity)
        {
            return entity.FirstName + " " + entity.LastName;
        }


    }
}
