using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Repository
{
    public class RepositoryClassroom : RepositoryBase<Classroom>, IRepositoryClassroom
    {
        public RepositoryClassroom(IRepository repository)
            : base(repository)
        {
        }
    }
}