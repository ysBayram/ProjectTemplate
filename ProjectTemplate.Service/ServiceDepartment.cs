using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Service;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Service
{
    public class ServiceDepartment : ServiceBase<Department>, IServiceDepartment
    {
        private readonly IBusinessDepartment _businessDepartment;

        public ServiceDepartment(IBusinessBase<Department> businessBase, IBusinessDepartment businessDepartment)
            : base(businessBase)
        {
            _businessDepartment = businessDepartment;
        }
    }
}