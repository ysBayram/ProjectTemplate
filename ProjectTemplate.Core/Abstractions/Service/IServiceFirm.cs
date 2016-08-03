using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Core.Abstractions.Service
{
    public interface IServiceFirm: IServiceBase<Firm>
    {
        Firm GetReservedCompanyByStudent(Trainee student);
    }
}