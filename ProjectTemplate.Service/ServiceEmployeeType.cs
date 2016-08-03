using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Service;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Service
{
    public class ServiceEmployeeType : ServiceBase<EmployeeType>, IServiceEmployeeType
    {
        private readonly IBusinessEmployeeType _businessEmployeeType;

        public ServiceEmployeeType(IBusinessBase<EmployeeType> businessBase, IBusinessEmployeeType businessEmployeeType)
            : base(businessBase)
        {
            _businessEmployeeType = businessEmployeeType;
        }
    }
}