using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Repository
{
    public class RepositoryIskurClassroom : RepositoryBase<IskurClassroom>, IRepositoryIskurClassroom
    {
        public RepositoryIskurClassroom(IRepository repository)
            : base(repository)
        {
        }
    }
}