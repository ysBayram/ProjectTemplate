using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Repository
{
   public class RepositoryControl:RepositoryBase<ControlEnt>,IRepositoryControl
    {
        public RepositoryControl(IRepository repository)
            : base(repository)
        {

        }
    }
}
