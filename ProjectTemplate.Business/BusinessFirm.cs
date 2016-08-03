using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Business
{
    public class BusinessFirm: BusinessBase<Firm>, IBusinessFirm
    {
        private readonly IRepositoryFirm _repositoryCompany;

        public BusinessFirm(IRepositoryBase<Firm> repositoryBase, IUnitOfWork uow, IRepositoryFirm repositoryCompany) : base(repositoryBase, uow)
        {
            _repositoryCompany = repositoryCompany;
        }

        public Firm GetReservedCompanyByStudent(Trainee student)
        {
            return _repositoryCompany.GetReservedCompanyByStudent(student);
        }
    }
}
