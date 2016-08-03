using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Service;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Service
{
    public class ServiceClassroom : ServiceBase<Classroom>, IServiceClassroom
    {
        private readonly IBusinessClassroom _businessClassroom;

        public ServiceClassroom(IBusinessBase<Classroom> businessBase, IBusinessClassroom businessClassroom)
            : base(businessBase)
        {
            _businessClassroom = businessClassroom;
        }
    }
}