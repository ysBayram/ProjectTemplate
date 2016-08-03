using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Service;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Service
{
    public class ServiceIskurClassroom : ServiceBase<IskurClassroom>, IServiceIskurClassroom
    {
        private readonly IBusinessIskurClassroom _businessIskurClassroom;

        public ServiceIskurClassroom(IBusinessBase<IskurClassroom> businessBase, IBusinessIskurClassroom businessIskurClassroom)
            : base(businessBase)
        {
            _businessIskurClassroom = businessIskurClassroom;
        }
    }
}