using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Service;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Service
{
    public class ServiceEmployee: ServiceBase<Employee>, IServiceEmployee
    {
        private readonly IBusinessEmployee _businessTeacher;

        public ServiceEmployee(IBusinessBase<Employee> businessBase, IBusinessEmployee businessTeacher) : base(businessBase)
        {
            _businessTeacher = businessTeacher;
        }

        public string GetFullName(Employee entity)
        {
            return _businessTeacher.GetFullName(entity);
        }
    }
   
}
