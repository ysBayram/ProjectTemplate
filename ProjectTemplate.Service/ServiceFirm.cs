using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Service;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Service
{
    public class ServiceFirm: ServiceBase<Firm>, IServiceFirm
    {
        private readonly IBusinessFirm _businessCompany;

        public ServiceFirm(IBusinessBase<Firm> businessBase, IBusinessFirm businessCompany) : base(businessBase)
        {
            _businessCompany = businessCompany;
        }



        public Firm GetReservedCompanyByStudent(Trainee student)
        {
            return _businessCompany.GetReservedCompanyByStudent(student);
        }
    }
}
