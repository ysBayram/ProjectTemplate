using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Business
{
    public class BusinessEmployeeHistory : BusinessBase<EmployeeHistory>, IBusinessEmployeeHistory
    {
        private readonly IRepositoryEmployeeHistory _repositoryTeacherLog;

        public BusinessEmployeeHistory(IRepositoryBase<EmployeeHistory> repositoryBase, IUnitOfWork uow, IRepositoryEmployeeHistory repositoryEmployeeHistory)
            : base(repositoryBase, uow)
        {
            _repositoryTeacherLog = repositoryEmployeeHistory;
        }

        public EmployeeHistory GetByTeacherId(int id)
        {
            return _repositoryTeacherLog.GetByTeacherId(id);
        }
    }
}