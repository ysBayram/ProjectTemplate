using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Service;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Service
{
    public class ServiceEmployeeHistory : ServiceBase<EmployeeHistory>, IServiceEmployeeHistory
    {
        private readonly IBusinessEmployeeHistory _businessEmployeeHistory;
        public ServiceEmployeeHistory(IBusinessBase<EmployeeHistory> businessBase, IBusinessEmployeeHistory businessEmployeeHistory):base(businessBase)
        {
            _businessEmployeeHistory = businessEmployeeHistory;
        }
        public EmployeeHistory GetByTeacherId(int id)
        {
            //burası değişecek
            return _businessEmployeeHistory.GetByTeacherId(id);
        }
    }
}
