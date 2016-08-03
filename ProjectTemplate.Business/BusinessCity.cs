using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Business
{
    public class BusinessCity : BusinessBase<City>, IBusinessCity
    {
        private readonly IRepositoryCity _repositoryCity;

        public BusinessCity(IRepositoryBase<City> repositoryBase, IUnitOfWork uow, IRepositoryCity repositoryCity)
            : base(repositoryBase, uow)
        {
            _repositoryCity = repositoryCity;
        }
    }
}