
using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Business
{
  public class BusinessControl: BusinessBase<ControlEnt> ,IBusinessControl
    {
        private readonly IRepositoryControl _repositoryControl;

        public BusinessControl(IRepositoryBase<ControlEnt> repositoryBase, IUnitOfWork uow, IRepositoryControl repositoryControl)
            : base(repositoryBase, uow)
        {
            _repositoryControl = repositoryControl;
        }
    }
}
