using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Repository
{
    public class RepositoryFirm: RepositoryBase<Firm>,IRepositoryFirm
    {
        public RepositoryFirm(IRepository repository):base(repository)
        {   
            
        }



        public Firm GetReservedCompanyByStudent(Trainee student)
        {
            if(student.ReservedFirmId != 0)
            {
                return GetById((int)student.ReservedFirmId);
            }
            else
            {
                return new Firm { Name = "" };
            }
        }
    }
}