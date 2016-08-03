using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Core.Abstractions.Repository
{
    public interface IRepositoryFirm:IRepositoryBase<Firm>
    {
        Firm GetReservedCompanyByStudent(Trainee student);
    }
}
