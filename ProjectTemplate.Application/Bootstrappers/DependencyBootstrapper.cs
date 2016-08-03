using ProjectTemplate.Business;
using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Abstractions.Service;
using ProjectTemplate.Core.EF;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.IoC;
using ProjectTemplate.Core.Repository;
using ProjectTemplate.Repository;
using ProjectTemplate.Service;
using System.Data.Entity;

namespace ProjectTemplate.Application.Bootstrappers
{
    /// <summary>
    /// Dependency bootstrapper
    /// </summary>
    public class DependencyBootstrapper : IBootstrapper
    {
        /// <summary>
        /// Bootstraps dependencies
        /// </summary>
        /// <param name="dependencyContainer"></param>
        public virtual void Bootstrap(IDependencyContainer dependencyContainer)
        {
            dependencyContainer.RegisterTransient<IUnitOfWork, EFUnitOfWork>();
            dependencyContainer.RegisterTransient<IRepository, EFRepository>();
            dependencyContainer.RegisterTransient<DbContext, ProjectTemplateContext>();

            dependencyContainer.RegisterTransient<IServiceBase<JobInterview>, ServiceBase<JobInterview>>();
            dependencyContainer.RegisterTransient<IRepositoryBase<JobInterview>, RepositoryBase<JobInterview>>();
            dependencyContainer.RegisterTransient<IBusinessBase<JobInterview>, BusinessBase<JobInterview>>();
            dependencyContainer.RegisterTransient<IServiceJobInterview, ServiceJobInterview>();
            dependencyContainer.RegisterTransient<IRepositoryJobInterview, RepositoryJobInterview>();
            dependencyContainer.RegisterTransient<IBusinessJobInterview, BusinessJobInterview>();
      
            dependencyContainer.RegisterTransient<IServiceBase<Firm>, ServiceBase<Firm>>();
            dependencyContainer.RegisterTransient<IRepositoryBase<Firm>, RepositoryBase<Firm>>();
            dependencyContainer.RegisterTransient<IBusinessBase<Firm>, BusinessBase<Firm>>();
            dependencyContainer.RegisterTransient<IServiceFirm, ServiceFirm>();
            dependencyContainer.RegisterTransient<IRepositoryFirm, RepositoryFirm>();
            dependencyContainer.RegisterTransient<IBusinessFirm, BusinessFirm>();

            dependencyContainer.RegisterTransient<IServiceBase<EmploymentStatus>, ServiceBase<EmploymentStatus>>();
            dependencyContainer.RegisterTransient<IRepositoryBase<EmploymentStatus>, RepositoryBase<EmploymentStatus>>();
            dependencyContainer.RegisterTransient<IBusinessBase<EmploymentStatus>, BusinessBase<EmploymentStatus>>();
            dependencyContainer.RegisterTransient<IServiceEmploymentStatus, ServiceState>();
            dependencyContainer.RegisterTransient<IRepositoryEmploymentStatus, RepositoryEmploymentStatus>();
            dependencyContainer.RegisterTransient<IBusinessEmploymentStatus, BusinessState>();

            dependencyContainer.RegisterTransient<IServiceBase<Trainee>, ServiceBase<Trainee>>();
            dependencyContainer.RegisterTransient<IRepositoryBase<Trainee>, RepositoryBase<Trainee>>();
            dependencyContainer.RegisterTransient<IBusinessBase<Trainee>, BusinessBase<Trainee>>();
            dependencyContainer.RegisterTransient<IServiceTrainee, ServiceTrainee>();
            dependencyContainer.RegisterTransient<IRepositoryTrainee, RepositoryTrainee>();
            dependencyContainer.RegisterTransient<IBusinessTrainee, BusinessTrainee>();

            dependencyContainer.RegisterTransient<IServiceBase<Department>, ServiceBase<Department>>();
            dependencyContainer.RegisterTransient<IRepositoryBase<Department>, RepositoryBase<Department>>();
            dependencyContainer.RegisterTransient<IBusinessBase<Department>, BusinessBase<Department>>();
            dependencyContainer.RegisterTransient<IServiceDepartment, ServiceDepartment>();
            dependencyContainer.RegisterTransient<IRepositoryDepartment, RepositoryDepartment>();
            dependencyContainer.RegisterTransient<IBusinessDepartment, BusinessDepartment>();


            dependencyContainer.RegisterTransient<IServiceBase<City>, ServiceBase<City>>();
            dependencyContainer.RegisterTransient<IRepositoryBase<City>, RepositoryBase<City>>();
            dependencyContainer.RegisterTransient<IBusinessBase<City>, BusinessBase<City>>();
            dependencyContainer.RegisterTransient<IServiceCity, ServiceCity>();
            dependencyContainer.RegisterTransient<IRepositoryCity, RepositoryCity>();
            dependencyContainer.RegisterTransient<IBusinessCity, BusinessCity>();

            dependencyContainer.RegisterTransient<IServiceBase<Classroom>, ServiceBase<Classroom>>();
            dependencyContainer.RegisterTransient<IRepositoryBase<Classroom>, RepositoryBase<Classroom>>();
            dependencyContainer.RegisterTransient<IBusinessBase<Classroom>, BusinessBase<Classroom>>();
            dependencyContainer.RegisterTransient<IServiceClassroom, ServiceClassroom>();
            dependencyContainer.RegisterTransient<IRepositoryClassroom, RepositoryClassroom>();
            dependencyContainer.RegisterTransient<IBusinessClassroom, BusinessClassroom>();

            dependencyContainer.RegisterTransient<IServiceBase<IskurClassroom>, ServiceBase<IskurClassroom>>();
            dependencyContainer.RegisterTransient<IRepositoryBase<IskurClassroom>, RepositoryBase<IskurClassroom>>();
            dependencyContainer.RegisterTransient<IBusinessBase<IskurClassroom>, BusinessBase<IskurClassroom>>();
            dependencyContainer.RegisterTransient<IServiceIskurClassroom, ServiceIskurClassroom>();
            dependencyContainer.RegisterTransient<IRepositoryIskurClassroom, RepositoryIskurClassroom>();
            dependencyContainer.RegisterTransient<IBusinessIskurClassroom, BusinessIskurClassroom>();

            dependencyContainer.RegisterTransient<IServiceBase<Education>, ServiceBase<Education>>();
            dependencyContainer.RegisterTransient<IRepositoryBase<Education>, RepositoryBase<Education>>();
            dependencyContainer.RegisterTransient<IBusinessBase<Education>, BusinessBase<Education>>();
            dependencyContainer.RegisterTransient<IServiceEducation, ServiceEducation>();
            dependencyContainer.RegisterTransient<IRepositoryEducation, RepositoryEducation>();
            dependencyContainer.RegisterTransient<IBusinessEducation, BusinessEducation>();

            dependencyContainer.RegisterTransient<IServiceBase<EmployeeType>, ServiceBase<EmployeeType>>();
            dependencyContainer.RegisterTransient<IRepositoryBase<EmployeeType>, RepositoryBase<EmployeeType>>();
            dependencyContainer.RegisterTransient<IBusinessBase<EmployeeType>, BusinessBase<EmployeeType>>();
            dependencyContainer.RegisterTransient<IServiceEmployeeType, ServiceEmployeeType>();
            dependencyContainer.RegisterTransient<IRepositoryEmployeeType, RepositoryEmployeeType>();
            dependencyContainer.RegisterTransient<IBusinessEmployeeType, BusinessEmployeeType>();


            dependencyContainer.RegisterTransient<IServiceBase<Branch>, ServiceBase<Branch>>();
            dependencyContainer.RegisterTransient<IRepositoryBase<Branch>, RepositoryBase<Branch>>();
            dependencyContainer.RegisterTransient<IBusinessBase<Branch>, BusinessBase<Branch>>();
            dependencyContainer.RegisterTransient<IServiceBranch, ServiceBranch>();
            dependencyContainer.RegisterTransient<IRepositoryBranch, RepositoryBranch>();
            dependencyContainer.RegisterTransient<IBusinessBranch, BusinessBranch>();

            dependencyContainer.RegisterTransient<IServiceBase<TraineeStatus>, ServiceBase<TraineeStatus>>();
            dependencyContainer.RegisterTransient<IRepositoryBase<TraineeStatus>, RepositoryBase<TraineeStatus>>();
            dependencyContainer.RegisterTransient<IBusinessBase<TraineeStatus>, BusinessBase<TraineeStatus>>();
            dependencyContainer.RegisterTransient<IServiceTraineeStatus, ServiceTraineeStatus>();
            dependencyContainer.RegisterTransient<IRepositoryTraineeStatus, RepositoryTraineeStatus>();
            dependencyContainer.RegisterTransient<IBusinessTraineeStatus, BusinessTraineeStatus>();


            dependencyContainer.RegisterTransient<IServiceBase<TraineeEmploymentStatus>, ServiceBase<TraineeEmploymentStatus>>();
            dependencyContainer.RegisterTransient<IRepositoryBase<TraineeEmploymentStatus>, RepositoryBase<TraineeEmploymentStatus>>();
            dependencyContainer.RegisterTransient<IBusinessBase<TraineeEmploymentStatus>, BusinessBase<TraineeEmploymentStatus>>();
            dependencyContainer.RegisterTransient<IServiceTraineeEmploymentStatus, ServiceTraineeEmploymentStatus>();
            dependencyContainer.RegisterTransient<IRepositoryTraineeEmploymentStatus, RepositoryTraineeEmploymentStatus>();
            dependencyContainer.RegisterTransient<IBusinessTraineeEmploymentStatus, BusinessTraineeEmploymentStatus>();


            dependencyContainer.RegisterTransient<IServiceBase<Employee>, ServiceBase<Employee>>();
            dependencyContainer.RegisterTransient<IRepositoryBase<Employee>, RepositoryBase<Employee>>();
            dependencyContainer.RegisterTransient<IBusinessBase<Employee>, BusinessBase<Employee>>();
            dependencyContainer.RegisterTransient<IServiceEmployee, ServiceEmployee>();
            dependencyContainer.RegisterTransient<IRepositoryEmployee, RepositoryEmployee>();
            dependencyContainer.RegisterTransient<IBusinessEmployee, BusinessTeacher>();

            dependencyContainer.RegisterTransient<IServiceBase<EmployeeHistory>, ServiceBase<EmployeeHistory>>();
            dependencyContainer.RegisterTransient<IRepositoryBase<EmployeeHistory>, RepositoryBase<EmployeeHistory>>();
            dependencyContainer.RegisterTransient<IBusinessBase<EmployeeHistory>, BusinessBase<EmployeeHistory>>();
            dependencyContainer.RegisterTransient<IServiceEmployeeHistory, ServiceEmployeeHistory>();
            dependencyContainer.RegisterTransient<IRepositoryEmployeeHistory, RepositoryEmployeeHistory>();
            dependencyContainer.RegisterTransient<IBusinessEmployeeHistory, BusinessEmployeeHistory>();

            dependencyContainer.RegisterTransient<IServiceBase<ControlEnt>, ServiceBase<ControlEnt>>();
            dependencyContainer.RegisterTransient<IRepositoryBase<ControlEnt>, RepositoryBase<ControlEnt>>();
            dependencyContainer.RegisterTransient<IBusinessBase<ControlEnt>, BusinessBase<ControlEnt>>();
            dependencyContainer.RegisterTransient<IServiceControl, ServiceControl>();
            dependencyContainer.RegisterTransient<IRepositoryControl, RepositoryControl>();
            dependencyContainer.RegisterTransient<IBusinessControl, BusinessControl>();

            dependencyContainer.RegisterTransient<IServiceBase<DataTypeEnt>, ServiceBase<DataTypeEnt>>();
            dependencyContainer.RegisterTransient<IRepositoryBase<DataTypeEnt>, RepositoryBase<DataTypeEnt>>();
            dependencyContainer.RegisterTransient<IBusinessBase<DataTypeEnt>, BusinessBase<DataTypeEnt>>();
            dependencyContainer.RegisterTransient<IServiceDataType, ServiceDataType>();
            dependencyContainer.RegisterTransient<IRepositoryDataType, RepositoryDataType>();
            dependencyContainer.RegisterTransient<IBusinessDataType, BusinessDataType>();

            dependencyContainer.RegisterTransient<IServiceBase<TraineeEmploymentStatusField>, ServiceBase<TraineeEmploymentStatusField>>();
            dependencyContainer.RegisterTransient<IRepositoryBase<TraineeEmploymentStatusField>, RepositoryBase<TraineeEmploymentStatusField>>();
            dependencyContainer.RegisterTransient<IBusinessBase<TraineeEmploymentStatusField>, BusinessBase<TraineeEmploymentStatusField>>();
            dependencyContainer.RegisterTransient<IServiceTraineeEmploymentStatusField, ServiceTraineeEmploymentStatusField>();
            dependencyContainer.RegisterTransient<IRepositoryTraineeEmploymentStatusField, RepositoryTraineeEmploymentStatusField>();
            dependencyContainer.RegisterTransient<IBusinessTraineeEmploymentStatusField, BusinessTraineeEmploymentStatusField>();

            dependencyContainer.RegisterTransient<IServiceBase<TraineeEmploymentStatusReason>,
                ServiceBase<TraineeEmploymentStatusReason>>();
            dependencyContainer.RegisterTransient<IRepositoryBase<TraineeEmploymentStatusReason>, RepositoryBase<TraineeEmploymentStatusReason>>();
            dependencyContainer.RegisterTransient<IBusinessBase<TraineeEmploymentStatusReason>, BusinessBase<TraineeEmploymentStatusReason>>();
            dependencyContainer.RegisterTransient<IServiceTraineeEmploymentStatusReason, ServiceTraineeEmploymentStatusReason>();
            dependencyContainer.RegisterTransient<IRepositoryTraineeEmploymentStatusReason, RepositoryTraineeEmploymentStatusReason>();
            dependencyContainer.RegisterTransient<IBusinessTraineeEmploymentStatusReason, BusinessTraineeEmploymentStatusReason>();

            dependencyContainer.RegisterTransient<IServiceBase<TraineeEmploymentStatusReasonDetail>, ServiceBase<TraineeEmploymentStatusReasonDetail>>();
            dependencyContainer.RegisterTransient<IRepositoryBase<TraineeEmploymentStatusReasonDetail>, RepositoryBase<TraineeEmploymentStatusReasonDetail>>();
            dependencyContainer.RegisterTransient<IBusinessBase<TraineeEmploymentStatusReasonDetail>, BusinessBase<TraineeEmploymentStatusReasonDetail>>();
            dependencyContainer.RegisterTransient<IServiceTraineeEmploymentStatusReasonDetail, ServiceTraineeEmploymentStatusReasonDetail>();
            dependencyContainer.RegisterTransient<IRepositoryTraineeEmploymentStatusReasonDetail, RepositoryTraineeEmploymentStatusReasonDetail>();
            dependencyContainer.RegisterTransient<IBusinessTraineeEmploymentStatusReasonDetail, BusinessTraineeEmploymentStatusReasonDetail>();
        }
    }
}
