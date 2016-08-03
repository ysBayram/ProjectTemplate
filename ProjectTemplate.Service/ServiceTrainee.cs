using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Service;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Service
{
    public class ServiceTrainee :ServiceBase<Trainee>, IServiceTrainee
    {
        private readonly IBusinessTrainee _businessStudent;

        public ServiceTrainee(IBusinessBase<Trainee> businessBase, IBusinessTrainee businessStudent)
            : base(businessBase)
        {
            _businessStudent = businessStudent;
        }

        public string GetFullName(Trainee entity)
        {
            return _businessStudent.GetFullName(entity);
        }
    }
}
