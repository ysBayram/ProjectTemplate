using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using ProjectTemplate.Core.Abstractions.Service;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Enums;
using ProjectTemplate.Infrastructure;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class InterviewController : Controller
    {
        /// <summary>
        /// Görüşmelerle ilgili CRUD ilşemlerinin yapıldığı controllerdır.
        /// </summary>
        private readonly IServiceJobInterview _serviceInterview;
        private readonly IServiceTrainee _serviceStudent;
        private readonly IServiceFirm _serviceCompany;
        private readonly IServiceBranch _serviceBranch;
        private readonly IServiceEducation _serviceEducation;
        private readonly IServiceEmploymentStatus _serviceEmploymentStatus;
        private readonly IServiceTraineeEmploymentStatus _serviceStudentWorkStateDetail;
        private readonly IServiceTraineeStatus _serviceInterviewState;
        private readonly IServiceEmployee _serviceTeacher;

        public InterviewController(IServiceJobInterview serviceInterview, IServiceTrainee serviceStudent, IServiceFirm serviceCompany, IServiceBranch serviceBranch, IServiceEducation serviceEducation, IServiceEmploymentStatus serviceEmploymentStatus, IServiceTraineeEmploymentStatus serviceStudentWorkStateDetail, IServiceTraineeStatus serviceInterviewState, IServiceEmployee serviceTeacher)
        {
            _serviceInterview = serviceInterview;
            _serviceStudent = serviceStudent;
            _serviceCompany = serviceCompany;
            _serviceBranch = serviceBranch;
            _serviceEducation = serviceEducation;
            _serviceInterviewState = serviceInterviewState;
            _serviceStudentWorkStateDetail = serviceStudentWorkStateDetail;
            _serviceEmploymentStatus = serviceEmploymentStatus;
            _serviceTeacher = serviceTeacher;
        }

        /// <summary>
        /// Tüm mülakatların listesi
        /// </summary>
        /// <returns></returns>
        public ActionResult Interviews()
        {
            List<InterviewModel> modelList = new List<InterviewModel>();

            IEnumerable<JobInterview> entList = _serviceInterview.GetAll().ToList();

            foreach (var ent in entList)
            {
                InterviewModel intModel = new InterviewModel
                {
                    InterviewId = ent.Id,
                    CompanyName = ent.Firm.Name,
                    Date = Convert.ToDateTime(ent.Date),
                    InterviewStateName = ent.InterviewStatus.Name,
                    ModelTypeName = ((ModelType)(ent.ModelType)).DisplayName(),
                    StudentFullName = _serviceStudent.GetFullName(ent.Trainee),
                    Result = ent.Description
                };


                modelList.Add(intModel);
            }

            return View(modelList);
        }

        /// <summary>
        /// Yeni mülakat ekleme
        /// </summary>
        /// <returns></returns>
        public ActionResult Add()
        {
            InterviewModel intModel = new InterviewModel
            {
                Students = _serviceStudent.GetAll().ToList(),
                Date = DateTime.Now,
                InterviewStates = _serviceInterviewState.GetAll().ToList(),
                Companies = _serviceCompany.GetAll().ToList()
            };


            Dictionary<int, string> modelTypes = new Dictionary<int, string>();

            foreach (var item in Enum.GetNames(typeof(ModelType)).ToList())
            {
                modelTypes.Add(Enum.GetNames(typeof(ModelType)).ToList().IndexOf(item) + 1, ((ModelType)Enum.GetNames(typeof(ModelType)).ToList().IndexOf(item) + 1).DisplayName());
            }

            intModel.ModelTypes = modelTypes;

            return View(intModel);
        }

        /// <summary>
        /// Yeni mülakat kaydetme işlemi
        /// </summary>
        [HttpPost]
        public ActionResult Add(InterviewModel interviewmodel)
        {

            JobInterview ie = new JobInterview
            {
                TraineeId = interviewmodel.StudentId,
                Date = interviewmodel.Date,
                InterviewStatusId = interviewmodel.InterviewStateId,
                ModelType = interviewmodel.ModelTypeId,
                FirmId = interviewmodel.CompanyId
            };


            _serviceInterview.Insert(ie);

            return RedirectToAction("Interviews");
        }


        /// <summary>
        /// Mülakat düzenleme
        /// </summary>
        public ActionResult Edit(int id)
        {
            var editItem = _serviceInterview.GetById(id);

            InterviewModel intModel = new InterviewModel
            {
                InterviewId = editItem.Id,
                Date = Convert.ToDateTime(editItem.Date),
                CompanyId = editItem.FirmId,
                CompanyName = editItem.Firm.Name,
                InterviewStateId = editItem.InterviewStatusId,
                InterviewStateName = editItem.InterviewStatus.Name,
                Result = editItem.Description,
                ModelTypeId = editItem.ModelType,
                ModelTypeName = ((ModelType)editItem.ModelType).DisplayName(),
                StudentId = editItem.TraineeId,
                StudentFullName = _serviceStudent.GetFullName(editItem.Trainee),
                Companies = _serviceCompany.GetAll().ToList(),
                Students = _serviceStudent.GetAll().ToList(),
                InterviewStates = _serviceInterviewState.GetAll().ToList()
            };



            Dictionary<int, string> modelTypes = new Dictionary<int, string>();

            foreach (var item in Enum.GetNames(typeof(ModelType)).ToList())
            {
                modelTypes.Add(Enum.GetNames(typeof(ModelType)).ToList().IndexOf(item) + 1, ((ModelType)Enum.GetNames(typeof(ModelType)).ToList().IndexOf(item) + 1).DisplayName());
            }

            intModel.ModelTypes = modelTypes;

            return View(intModel);
        }

        /// <summary>
        /// Mülakat düzenleme işleminin kaydedilmesi
        /// </summary>
        [HttpPost]
        public ActionResult Edit(InterviewModel interviewmodel)
        {
            JobInterview intEnt = _serviceInterview.GetById(interviewmodel.InterviewId);

            intEnt.FirmId = interviewmodel.CompanyId;
            intEnt.InterviewStatusId = interviewmodel.InterviewStateId;
            intEnt.ModelType = interviewmodel.ModelTypeId;
            intEnt.TraineeId = interviewmodel.StudentId;
            intEnt.Date = interviewmodel.Date;
            intEnt.Description = interviewmodel.Result;

            _serviceInterview.Update(intEnt);

            return RedirectToAction("Interviews");
        }

        /// <summary>
        /// Mülakat silme
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Delete(int id)
        {
            var interview = _serviceInterview.GetById(id);

            interview.IsDeleted = true;

            _serviceInterview.Update(interview);

            return RedirectToAction("Interviews");
        }

        public ActionResult StudentWorkStateEdit(int id)
        {
            StudentWorkStateEditModel studentWorkState = new StudentWorkStateEditModel()
            {
                StudentId = id,
                EmploymentStatus = _serviceEmploymentStatus.GetAll().ToList(),
                ModifiedDate = DateTime.Now,
                Description = ""
            };

            return View(studentWorkState);
        }



        [HttpPost]
        public ActionResult StudentWorkStateEdit(FormCollection collection)
        {
            //DateTime dt = Convert.ToDateTime(collection.Get("ModifiedDate")).Add(DateTime.Now.TimeOfDay);

            // StudentWorkStateDetailEnt student = new StudentWorkStateDetailEnt()
            //{
            //StudentId = Convert.ToInt32(collection.Get("StudentId")),
            //StudentWorkStateId = Convert.ToInt32(collection.Get("StudentWorkStates")),
            //ModifiedDate = dt,
            //Description = collection.Get("Description")
            //};


            //_serviceStudentWorkStateDetail.Insert(student);

            return RedirectToAction("StudentInterviews", "Interview");
        }
        //******************************************************************************************************* 


        /// <summary>
        /// Öğrencileri ve o öğrencilere ait son 3 mülakatı listeleme
        /// </summary>
        /// <returns></returns>
        public ActionResult StudentInterviews()
        {
            List<StudentInterviewModel> listStudentInterview = new List<StudentInterviewModel>();

            foreach (var student in _serviceStudent.GetAll())
            {
                StudentInterviewModel studentInterview = new StudentInterviewModel
                {
                    Id = student.Id,
                    IdentityNumber = student.TcIdentity,
                    FullName = _serviceStudent.GetFullName(student),
                    TeacherFullName = _serviceTeacher.GetFullName(student.EmployeeHistories.OrderByDescending(x => x.Date).FirstOrDefault().Employee),
                    BranchName = student.KursiyerEğitims.OrderByDescending(x => x.EducationEndDate).FirstOrDefault().IskurClassroom.Classroom.Branch.Name,
                    IskurClass = student.KursiyerEğitims.OrderByDescending(x => x.EducationEndDate).FirstOrDefault().IskurClassroom.IskurCode,
                    EducationName = student.KursiyerEğitims.OrderByDescending(x => x.EducationEndDate).FirstOrDefault().Education.Department.Name,
                    StudentWorkState = "",//StudentWorkState = student.StudentWorkStateDetails.Select(x => x.StudentWorkState.Name).ToString(),  // düzenlenecek
                    StateDescription = "",//StateDescription = student.StudentWorkStateDetails.Select(x => x.StudentWorkState.Name).ToString(),  // düzenlenecek
                    LastInterviewDate = (DateTime)student.Interviews.OrderByDescending(y => y.Date).FirstOrDefault().Date,
                    ReserverdCompanyName = _serviceCompany.GetReservedCompanyByStudent(student).Name,
                    Interviews = _serviceInterview.GetLastInterviews(student, 3).ToList()
                };

                listStudentInterview.Add(studentInterview);
            }

            return View(listStudentInterview);
        }

        /// <summary>
        /// Mülakatların takvim üzerinde gösterilmesi
        /// </summary>
        /// <returns></returns>
        public ActionResult InterviewsCalendar()
        {
            var allInterviews = _serviceInterview.GetAll().ToList();

            List<InterviewCalendarModel> interviewList = new List<InterviewCalendarModel>();

            foreach (var interview in allInterviews)
            {
                interviewList.Add(new InterviewCalendarModel()
                {
                    Id = interview.Id,
                    Title = _serviceStudent.GetFullName(interview.Trainee),
                    Year = interview.Date.Value.Year,
                    Month = interview.Date.Value.Month,
                    Day = interview.Date.Value.Day,
                    Hour = interview.Date.Value.Hour,
                    Minute = interview.Date.Value.Minute,
                    CompanyName = interview.Firm.Name,
                    State = interview.InterviewStatus.Name,
                    Model = ((ModelType)interview.ModelType).DisplayName(),
                    Result = interview.Description
                });
            }

            return View(interviewList);
        }











    }
}