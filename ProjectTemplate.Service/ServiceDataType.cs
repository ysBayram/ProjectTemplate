using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Service;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Service
{
   public class ServiceDataType: ServiceBase<DataTypeEnt>, IServiceDataType
    {
        private readonly IBusinessDataType _businessDataType;

        public ServiceDataType(IBusinessBase<DataTypeEnt> businessBase, IBusinessDataType businessDataType)
            : base(businessBase)
        {
            _businessDataType = businessDataType;
        }
    }
}
