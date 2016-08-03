using System.Data.Entity;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.FluentMappings;

namespace ProjectTemplate.Core.EF
{
    public class ProjectTemplateContext : DbContext
    {
        public ProjectTemplateContext()
            : base("ProjectTemplateContext")
        {
            //Database.SetInitializer(new CreateDatabaseIfNotExists<ProjectTemplateContext>());
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ProjectTemplateContext, ProjectTemplateConfiguration>());
        }

        public virtual DbSet<JobInterview> JobInterview { get; set; }
        public virtual DbSet<Firm> Firm { get; set; }
        public virtual DbSet<EmploymentStatus> EmploymentStatus { get; set; }
        public virtual DbSet<Trainee> Trainee { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Branch> Branch { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Classroom> Classroom { get; set; }
        public virtual DbSet<Education> Education { get; set; }
        public virtual DbSet<TraineeStatus> TraineeStatus { get; set; }
        public virtual DbSet<IskurClassroom> IskurClassroom { get; set; }
        public virtual DbSet<Term> Term { get; set; }
        public virtual DbSet<EmployeeType> EmployeeType { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<EmployeeHistory> EmployeeHistory { get; set; }
        public virtual DbSet<TraineeEmploymentStatus> TraineeEmploymentStatus { get; set; }
        public virtual DbSet<TraineeEmploymentStatusReason> TraineeEmploymentStatusReason { get; set; }
        public virtual DbSet<TraineeEmploymentStatusReasonDetail> TraineeEmploymentStatusReasonDetail { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BranchMap());
            modelBuilder.Configurations.Add(new CityMap());
            modelBuilder.Configurations.Add(new ClassroomMap());
            modelBuilder.Configurations.Add(new ControlMap());
            modelBuilder.Configurations.Add(new DepartmentMap());
            modelBuilder.Configurations.Add(new DataTypeMap());
            modelBuilder.Configurations.Add(new EducationMap());
            modelBuilder.Configurations.Add(new EmployeeMap());
            modelBuilder.Configurations.Add(new EmployeeHistoryMap());
            modelBuilder.Configurations.Add(new EmployeeTypeMap());
            modelBuilder.Configurations.Add(new EmploymentStatusMap());
            modelBuilder.Configurations.Add(new FirmMap());
            modelBuilder.Configurations.Add(new IskurClassroomMap());
            modelBuilder.Configurations.Add(new JobInterviewMap());
            modelBuilder.Configurations.Add(new TraineeEmploymentStatusMap());
            modelBuilder.Configurations.Add(new TraineeEmploymentStatusReasonMap());
            modelBuilder.Configurations.Add(new TraineeEmploymentStatusReasonDetailMap());
            modelBuilder.Configurations.Add(new TraineeEmploymentStatusFieldMap());
            modelBuilder.Configurations.Add(new TermMap());
            modelBuilder.Configurations.Add(new TraineeMap());
            modelBuilder.Configurations.Add(new TraineeStatusMap());
        }
    }
}
