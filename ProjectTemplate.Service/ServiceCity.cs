using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Service;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Service
{
    public class ServiceCity : ServiceBase<City>, IServiceCity
    {
        private readonly IBusinessCity _businessCity;

        public ServiceCity(IBusinessBase<City> businessBase, IBusinessCity businessCity)
            : base(businessBase)
        {
            _businessCity = businessCity;
        }
    }
}